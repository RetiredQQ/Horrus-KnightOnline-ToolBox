
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER procedure [dbo].[_HorrusTB_DecodeStrItem]    @strUserId varchar(30),    @displayAll bit = 1
AS
BEGIN
	declare @T_PlayerItems TABLE(	
		Slot int, 	
		Num int,
		strName char(50),	
		MaxDuarbility 	smallint, 
		CurrentDuarbility smallint, 
		ItemCount smallint,
	    ItemFlag tinyint,
		ItemExpireTime int
	);

	declare @ItemID int;
	declare @strName char(50);
	declare @MaxDuarbility smallint;
	declare @ItemDuration smallint;
	declare @ItemCount smallint;


	declare @ItemSerial Bigint;
	declare @ItemFlag tinyint;
	declare @ItemExpireTime int;
	declare @strItemTime binary(300);


	declare @binaryData varbinary(600);
	declare @strSerial varbinary(600);
	set @binaryData = cast((select strItem from USERDATA where strUserId = @strUserId) as varbinary(600));
	set @strSerial = cast((select strSerial from UserData where strUserId = @strUserId) as varbinary(600));
	set @strItemTime = cast((select strItemTime from UserData where strUserId = @strUserId) as binary(300));

	DECLARE @binaryLoop INT = 1, @binaryLoopEx INT = 1, @ItemPos INT = 0;
	WHILE (@binaryLoop < 600)
	begin
	
		set @strName         = (SELECT TOP 1 strName FROM ITEM WHERE Num = CAST(CAST(REVERSE(SUBSTRING(@binaryData, @binaryLoop, 4)) AS VARBINARY) AS INT));
		
		--set @ItemNameNum        = cast(cast(reverse(substring( @binaryData, @binaryLoop*8-7, 4 )) as varbinary(4)) as int);
		set @ItemID = CAST(CAST(REVERSE(SUBSTRING(@binaryData, @binaryLoop, 4)) AS VARBINARY) AS INT);	
		set @ItemDuration = CAST(CAST(REVERSE(SUBSTRING(@binaryData, @binaryLoop + 4, 2)) AS VARBINARY) AS SMALLINT);
		set @ItemCount = CAST(CAST(REVERSE(SUBSTRING(@binaryData, @binaryLoop + 6, 2)) AS VARBINARY) AS SMALLINT);
		
		/*ItemPos*/
		set @ItemPos = @ItemPos;
		
		set @MaxDuarbility = (select Duration from ITEM where Num=@ItemID);
		
		set @ItemSerial = (CAST   (CAST(REVERSE(  SUBSTRING(@strSerial, @binaryLoop, 16)  ) AS VARBINARY) AS BIGINT)  );

		set @ItemFlag = CAST(CAST(REVERSE(SUBSTRING(@strItemTime, @binaryLoopEx, 1)) AS VARBINARY) AS TINYINT);
		set @ItemExpireTime = CAST(CAST(REVERSE(SUBSTRING(@strItemTime, @binaryLoopEx + 1, 4)) AS VARBINARY) AS INT);

		insert into @T_PlayerItems values(@ItemPos, @ItemID, @strName, @ItemDuration, @MaxDuarbility, @ItemCount, @ItemFlag, @ItemExpireTime);

		SET @binaryLoop += 8;
		SET @binaryLoopEx += 5;
		SET @ItemPos = @ItemPos + 1;
		
	   --insert into @T_PlayerItems values(@i, @ItemNameNum, @strName, @MaxDuarbility, @int16Duarbility, @int16ItemCount);
	 	
	end 

	if @displayAll = 1
		select * from @T_PlayerItems;
/*	else
		select * from @T_PlayerItems where strName is not null;*/
END