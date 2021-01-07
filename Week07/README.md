## Topic: 

For this discussion you will need to research the difference between Two-dimensional and parallel arrays.  Image you are creating a program that will utilize an array to store information about a user and their phone number.  Should you use a two-dimensional or parallel array?  For the initial post choose which method you would use and justify your decision.  For the response post, choose a post from a classmate and give a possible issue that could arise from the method they have chosen.  Be sure to be in depth and support your posts with justifications.

## Response:

A two dimensional array has all data in a single data type, where as a parallel array has mismatching types (as found [here](http://www-acad.sheridanc.on.ca/~jollymor/prog24178/arrays2c.htmlhttp://www-acad.sheridanc.on.ca/~jollymor/prog24178/arrays2c.html)) 

Moving forward we have to accept a fact when writing code 👏phone👏numbers👏are👏strings👏 because a) they are formatted and b) you should not be able to do math to a phone number. 

This discussion becomes infinitely more complex when you tak the tiem to ask your self what information is being stored about a user. If you follow the Idea that the information being stored is a name (which is a string) then a two dimensional array is the way to go on this problem. However you could also interpret that the information is instead an ID (which is probably an integer) in which case the parallel array is the best way to go. In short it really depends on how you interpret the data