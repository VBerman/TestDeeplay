# TestDeeplay
This website was created for personnel accounting in the enterprise.
## What has been implemented? 
1. Designed and created database;
2. Designed and created back-end side;
3. Designed and created front-end side;
4. Full CRUD employees;
5. Grouping employees by departments and posts.
## What will be implemented in the future?
1. CRUD unique information for post.  

## Database structure 
At the moment database structure allows fill unique information:
![image](https://user-images.githubusercontent.com/61354229/173139638-af47c79b-7732-4e34-bd7a-864be84a6ab4.png)  

You can get acquainted with the structure of the backend and frontend in the project itself.

## Result
You can see the result at the link (temporary):
https://laughing-kowalevski.31-31-196-234.plesk.page/

## How to start a project
1. Open project with Visual Studio that supported .NET 6.0;
2. Change connection string in appsettings.Development.json (for publish need create *.Production.json);
![image](https://user-images.githubusercontent.com/61354229/173141784-45e69851-6e6f-4331-8df9-b0611cf92d30.png)
3. In Powershell input a command "Add-Migration *NameYourMigration*";
4. After input a command "Update-Database" (the database will be created at the path you specified in the connection string);
5. Then you can start a project. But for full use program I recommend fill Posts and Departments in Database.

## Applied technology stack
For front-side:
1. Blazor WebAssembly;
2. MudBlazor (framework).  
 
For back-end:
1. ASP.NET.

For database:  
1. SQLServer.

## Project timeline
The project was created in one day.
Therefore, there may be flaws, since there was no time to write testing.

# Summary
As a result, a project was developed for personnel management with the possibility of input and output of information.  

Thank you for your attention.


  
