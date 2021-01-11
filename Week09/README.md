## Topics:

For this discussion you will be reviewing the data structures of Arraylists and Dictionaries.  Imagine you will be needing a data structure that will hold the user name, email and salary for an employee.  For the initial post choose whether you would choose an arraylist or dictionary for this and give several justifications.  For the response post, choose one of your classmates posts and give a reason why the opposite of their choice would be beneficial.  Be sure to be in depth and support your posts with justifications.

## Response:

Lets go over the possible data types for each of the members we have outlined here

User name : String
Email : String
Salary : Double | String

Because we have some context clues for these members it makes much more sense to store dictionary where the keys are strings and the values are objects. Now I say that the values are objects because that way we can store Salary as a double and just use a simple `(double)` or `(string)` cast on the values were applicable. If we needed to store multiple user diagrams I would wrap that in an array list.