# Sales Lead Project
 
Sales lead Project is a simple web application for creating and viewing sales leads. The application allows users to create sales leads and displays a list of leads sorted by the likelihood that they will buy. 

I used multi-tier approach to split the application into two layers: presentation layer and service layer so that it will be easier to test and change the business logic and database code. The presentation layer contains the views and controllers that display the html form and table for creating and listing leads. The service layer contains the logic for the "buying likeliness indicator" and the database code for saving, sorting and retrieving leads from the database. 

## Tools and Technology used

- I used ASP.NET Core, C#, web application server and the MVC pattern
- I stored leads into a database using SQLite database engine.
- I used an object-relational mapper called Entity Framework Core for data access
_  I created a Web page with two views that the user will interact with via the browser (Display leads and add new lead)
_ I used A REST Api controller that exposes api endpoints so that the HTTP services for getting and posting leads can be accessed from any client application including browsers and mobile devices


### Getting started
Clone repo and go into the project directory.

### Prerequisites
You will need to Install the .NET Core 2.2 SDK. to run the site


## Running the app

You can use dotnet CLI tools: navigate to the salesleadNet folder and use dotnet CLI commands.
```
cd salesLeadNet
dotnet run
```
If you are using Visual Studio or Visual Studio for Mac: Open the project by selecting File > Open > Project/Solution from the menu bar, navigate to the salesleadNet project folder, and select the project file (.csproj or .fsproj).

If you are using Visual Studio Code: Open the project by selecting File > Open Folder from the menu bar and selecting the salesLeadNet project folder.

## Navigating the site 

Open your web browser and navigate to http://0.0.0.0:5000/

They are two buttons on the top nav bar: Display Leads and Add new lead. Clicking on the button will lead you to creating the leads form and displaying leads.

If you are cosuming the api from different client application use http://0.0.0.0:5000/api/getleads or http://0.0.0.0:5000/api/addlead to send and recieve Json data from the webserver


## CODE FILES  

SERVICE layer
The service directory contains two files: IleadService and Leadservice which are the C# Interface and Class that contains the business logic and the database code

MODELS

Used two separate model classes: a model
that represents the lead entity in the database, and the model that will be combined with a view and sent back to the user's browser


CONTROLlERS
two seperate controllers used: an api controller that exposes api endpoints for wide range client applications and MVC controller that handles incoming requests within the application and serves the view

VIEW

The view uses Razor templating language, which combines HTML and C# code.
they are two views: one for creating the form for entering new leads details and one for displaying a table contains list of leads




## Author

* **Abdikarim Mohamed**


