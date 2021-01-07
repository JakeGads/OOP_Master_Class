## Topic:

For this discussion you will be researching repetition structures, also known as loops.  There are several different types of loops, such as while, for, do-while, etc.  For the initial post, imagine you will be creating a loop to run a specific number of times.  Choose one of the loop methods to utilize and justify why you have chosen that method.  For the response post, take a classmates post and give a possible issue that would arise with the method they have chosen.  Be sure to be in depth and justify your posts.

## Response:

Any time a loop has a specified number of iterations the go-to implementation is the `for` loop. This isn't necessarily because of speed but because the three basic parts of a known-n loop are called in the creation of the loop.
`
`for(int i = 0; i < 10; i++)`

### Instantiation 

`int i = 0;` in this step we make a variable that we will be using to measure how many iterations we have gone through. This step only runs once.

### Condition 

`i < 10;` in this step we check to see the current status of i against whatever iteration we are testing. this step will run at the start of every loop.

### Value Updating (incrementation)

`i++` in this step we update the value of i for the next step. In general this is run at the end of ever loop. It should also be mentioned that you can use prefix increment (`++i`) and it will run before every implementation but it is generally considered a code smell for Contrived Complexity.

## So ...

because all of these steps are preferred in one easy to read line using a for loop makes the code easier to read which is really the goal for any programmer