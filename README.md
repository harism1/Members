# Membership website

Simple and quick project I made a while back for mainly learning ASP.NET, the MVC (Model View Controller) architecture, databases and handling them in a DBMS.

A lot of the implementations either don't make sense, weird or are unnecessary. As I already mentioned, this is purely for practicing the concepts mentioned above (e.g. I made different Models - in this case, Males, Females, and Others - so I had a reason to implement different migrations). 

## How it works

![ezgif com-gif-maker (2)](https://user-images.githubusercontent.com/80421211/195136305-b972f391-3183-44b7-a313-b00051b7e197.gif)

This website uses a simple CRUD architecture, and it's purpose is managing members who use some sort of service inside a database.

It is meant to be used strictly by the owners of said service, i.e. the person keeping track of the members.

The members are divided into three groups - Males, Females, and Other.

Each one has some common properties, and a few unique ones.

On the index page of the website, you can navigate through the three groups using three buttons.

After clicking on one, you see the list of all members of such group inside the database.

You can create a new member, or edit or delete an already existing one. Each property has validation checks.

After creating, editing, or deleting a member you get a notification that states whether said operation was successful or not.

- Implemented using toastr javascript library https://github.com/CodeSeven/toastr
