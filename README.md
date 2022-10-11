# Membership website

Simple and quick project I made a while back for mainly learning ASP.NET, the MVC (Model View Controller) architecture, databases and handling them in a DBMS.

A lot of the implementations either don't make sense, weird or are unnecessary. As I already mentioned, this is purely for practicing the concepts mentioned above (e.g. I made different Models - in this case, Males, Females, and Others - so I had a reason to implement different migrations). 

## How it works

This website uses a simple CRUD architecture, and it's purpose is to keep track of members of some sort of service.

It is meant to be used strictly by the owners of said service, i.e. the person keeping track of the members.

The members are divided into three groups - Males, Females, and Other.

Each one has some common properties, and a few unique ones.

On the index page of the website, you can navigate through the three groups using three buttons.

After clicking on one, you see the list of all members of such group in the database.

You can create a new member, or edit or delete an already existing one.

After creating, editing, or deleting a member you get a notification that states whether said operation was successful or not.

- Implemented using toastr javascript library https://github.com/CodeSeven/toastr
