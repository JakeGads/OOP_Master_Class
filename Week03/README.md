## Topic

For this discussion you will be researching decision structures.  There are several different types of decision structures, for the initial post, imagine you will be creating a decision structure.  Choose either: if statement or a switch statement as the decision structure to utilize and justify why you have chosen that method.  For the response post, take a classmates post and give a possible issue that would arise with the method they have chosen.  Be sure to be in depth and justify your posts.

## Response

My brother is a digital artist and he has spent a decent amount of this quarantine designing new computer desktop wallpapers and I would love to use as my desktop.

```cs
// we pick a random number between 1 and 3 (inclusive)
int random_number = new Random().Next(1,4);

// switch over that
switch(random_number){
    // if that number was one
    case 1:
        wallpaper = wallpaper1;
    // if that number was 2 
    case 2:
        wallpaper = wallpaper2;
    // if that number was 3
    case 3:
        wallpaper = wallpaper3;
    // if somehow the numbers fell outside fo the range
    // it will never actually reach here but I wanted to show the catch all for the sake of the example
    default:
        wallpaper = wallpaper1;
}
```

The idea here is that this would actually change my wallpaper (I think I may be missing some code but hey we can pretend can't we). My reasoning for using a `switch` statement instead of an `if/else` statement is that it will technically be faster. [Geeks for Geeks](https://www.geeksforgeeks.org/switch-vs-else/) explains the main difference here excellently, when using `if` statements every statement must be checked until either you reach a boolean statement that equates to `True` or you run out of `if`'s to check where as with a `switch` it will not need to test because it has already been compiled down. 