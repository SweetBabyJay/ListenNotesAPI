# ListenNotes Api - Jason Becker 9/19/2022 #

The purpose of this project is to output a json object upon a Get request. Right now, anyone who knows about the url could be able to retrieve the information so having some form of security would be beneficial. Luckily we are not providing sensitive information.

This project DOES NOT have pagination nor does it limit the result to 5 entries. Due to unforeseen issues during development, I have elected to omit pagination (for now) to instead ensure people can access the data.

# Instructions #
You can run the project in visual studio and the launch url should take you to localhost:7190/podcasts where the json object is displayed.

** If the database is not set up, you can run dotnet ef database update and it should grab the existing migrations and update the database.

** If there is no data in the database, you can run the save method to insert data. This can be done by adding /save into the url (so it looks like localhost:7190/podcasts/save)

# Issues I ran into #
- New to the project structure requirements. Ended up using https://medium.com/swlh/building-a-nice-multi-layer-net-core-3-api-c68a9ef16368 as a beginning reference. I think this may have introduced some unneeded bloat in the structure.
- The json podcasts were not being saved into the database for a while. I'm not sure why as it started working as expected on the due date :(.
- The json returned has a loop for the genres. This is because, when i first started, I thought it would be beneficial to have that many-to-many relationship.
  As I got into development, I decided it would be easier to change it to be a one-to-many relationship since the requirements were to only display genres for 
  the podcasts and not display podcasts per genre (since were only concerned with genre 140). 

# What I learned #
- .Net 6 is a little more confusing having removed the startup class from .Net 5. It looks cleaner now
- The dynamic object type is cool and useful for a project like this! You can define custom object at runtime to loop through (controllers/podcastcontroller line 41).
- The mitochondria is the powerhouse of the cell
- Making an API with one get method is not complicated IN THEORY but there's always something that likes to go wrong and hold you up.

# Questions: #
1. What benefits does using the defined structure have (api, domain, data, services)? I thought it would be fine with an api/controller layer, domain for the models, and data for the classes that connect to the database. would services be beneficial in introducing middleware for security purposes?
2. What sort of security would you have liked to see for a project like this and how would you have implemented it? I'm guessing you could do role based security at least
3. Is there a finished project like this to compare what I did with how you imagined it?