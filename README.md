# Horrus-ToolBox
Originally the idea behind this project was to create an open source Iventory Editor as I didnt meet any tool of such kind that was publicly release to community with open code.
As the time progress more and more features has been added so I decided to move it into someting more like a MultiEditor tool. 
However the downside of that was that the code become more complex and kind of messy. 
Right now Inventory Editor and Table Editor works pretty well so I decided to share the code as it is hoping that to find some colaborators and futher improve this project by adding more features.

# Current Features
Right now tool contains such features as :
- Inventory Editor
- Table Editor
- Item Creator (not fully completed !! I took bad approach, this feature has to be re-worked )

# Requirmetns 
.Net 6.0
Inventory Editor requires some stored procedures to be run manully 

# Code information
- static class CoreServices works as an main functionality manager class. It contins static object for logger, database connection as well as main Forms.

- Forms are divided into separated folder as per functionality
- Table Editor encodings are stored in separated folder. Code was based on https://github.com/mustafakemalgilor/ko-table-editor
   



# Inventory Editor features:
- User search by name/clan/level
- Fully working UI view 
- User inventory Loading/Saving/Reloading
- Drag & Drop items, 
- Coins Change (Coins can be provided in format with spaces ex. 200 000)
- Delete button with confirmation window
- Changing stackable item amount
- Item information displayed on side panel
- Stackable items - display information amount
- Search Item panel with filtering options
- Creating new item by Drag & Drop Icon or Element from list
- Database Interface implementation for easy extend (2 version atm: 1298, 1098)
- Default Config Loading from Json file (Automatic config save on successful DB connection)
- Additional file with mapping ItemNumID with IconIconID 
- Copy item ID

# Table Editor Feature:
- Table Custom header json (can be easily adjusted for any KO version)
- Improved DataGridView performance
- Drag & Drop file Load
- Load/Save from the context menu
- Common encryption/decryption methods (from Pentagram Editor)
- Find text in whole Table
- Filter out specific column 
- Sorting by header
- Adding/removing Columns/Rows
- Exporting to SQL insert

# Item Creator Feature: 
- Json file mapping for TBL column naming
- Dynamic forms creation depending on Database [dbo].[Item] table
- Prepare Insert statement 
- Direct Insert into database
- Adding new row to Item_org & item_Ext
- Copy values to Item_org & item_Ext (required customization and adjustments)
- Creating new row just for DB & item_ext table (Is Ext Only - checkbox)
- Default filtering to show newly added row

# Miscellaneous:
- Error logger - default logs to Error_log.txt
- Json configuration
- Item icons folders with over 3,7k elements
- Json mapping for Table Editor headers
 
