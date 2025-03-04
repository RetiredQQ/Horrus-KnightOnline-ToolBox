SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER procedure [dbo].[_HorrusTB_EncodeStrItem] @strUserId char(50), @binaryData varbinary(400)
AS

declare @binaryDataNew varbinary(400);
declare @strItemNew varchar(400);

set @binaryDataNew = cast((select strItem from USERDATA where strUserId = @strUserId) as varbinary(400));
set @strItemNew = cast((@binaryData) as varchar(400));
update USERDATA set strItem = @strItemNew where strUserId = @strUserId

select strItem from USERDATA where strUserId = @strUserId
