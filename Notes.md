# Notes on this project
## forms
* Action Attribute- indicates where the given form will route to in the project
* Method Attribute- need a post method if form is being used to create a new object
* required eliments
* submit button
* remember to add route to HomeController!
* Name Attribute- matches the route decorator in controller

# HomeController
* the link from Index.cshtml invokes this route
* returns View()
* the name of the ActionResult is the same name as the .cshtml file, so knows which one to choose to render
* The CreateForm() route method will automatically render this view.

# View()
* can have varying number of arguments
* first- specify the vire that should be returned
* second- specify what the Model property on the view should be

# Action Result
* class that Routes return

# Route Decorator
* kind of like the argument that goes inside route
* matches the name attribute of the form action

# Generating a Request
* Three ways to access a page- 
  * type url
  * click a link
  * submit a form
* client makes server request
* Method, Path, Headers, Body 
* Verbs are another word for http methods

* post requests aim to change something on the website's server
  * examples: add, update, delete

* Path - itendifies the web resources that should be retrieved/acted on (GET/POST)
* Headers- provide server more info about the client, server and request
  * host-- domain of ther server
  * user-agent-- software acting on behalf of the suer to make the request
  * Accept-language-- human language accepted for response

* Body-- any data that must be sent to server
  * ex: the info in a form that a user entered

* Viewing Requests
  * use chrome developer tools to view
  
* Routing in MVC Controllers
  * controller is responsible for bringing view data and class methods together
  * route decorators indicate the corresponding path
  * Does our application make a server?
  * our server can identify what resource should be retrieved and sent back
  * executes the route's code

# better annotaton for defining the routes

* [HttpGet("route-name")] for GET
* [HttpPost("route-name)] for POST

* the browser receives the response from the server, it then renders the HTML into a viewable format for the user.

# Pasing model to view
* https://www.tutorialsteacher.com/mvc/mvc-view

@foreach (Item item in Model)
  {
    <li> 
      @Html.DisplayFor(modelItem => item.Description)
    </li>
  }


# Migrations Section

* CategoryItem model
  * class to hold info about the relationship between Category and Item
  * Entity use this to create Join TAble

* Each DbSet in context class becomes a table (entity does this)

* design time -- need database before run time
  * time when we are actually writing and designing our code


* dotnet ef migrations add Initial
  * run this at root of project directory
  * creates a Migrations folder in root directory
  * entity looks at project's models, then creates migrations based on what it finds

* dotnet ef database update
  * command to apply migration

----

```c++
public ActionResult Details(int id)
{
    var thisItem = _db.Items // gives us list of Item objects in database
        .Include(item => item.Categories) 
        .ThenInclude(join => join.Category)
        .FirstOrDefault(item => item.ItemId == id);
    return View(thisItem);
}
```


* ItemsController.cs   (the above code)
  * inlcude -- get categories property for each item
  * but Categories property is actually a collection of join entities --- not ACTUAL categories
  * since need actual categories, use ThenInclude() method to load the Category of each CategoryItem
  * CategotyItem is reference to a relationship
  * returning the associated category of a category Item
  * FirstOrDefault() method specifies which items from the database we are working with 