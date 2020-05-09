# c#EntityFrameworkRestaurantPOSProject

This project was made for my Client Server Relations course in Douglas College with another classmate of mine. We have used Entity Framework and MSSQL Server in combination with a basic Windows Forms frontend.

It is a restaurant POS management app, that has a simple receipt and table management for servers in addition to employee management for managers. Report file in the root folder shows our database schemas and how to use the app. Uses employee.json in the resources folder to initialize the first database for employees and itemList.json in the root folder for a already made item list for you to import manually in the manager tab. 

Now this project has some design problems and suffers from some bad practice, for example passing the entity context to some functions and creating a new context in others and using one class for all of the functions of the app (To be honest, this was how our instructor wanted it, but still.). We only had 2 weeks for this project so once something worked I didnt go back and tidy up after myself. I still want to go back and clean everything up at some point when I have the time, but for now this have to do.
