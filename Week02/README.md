## Topic

For this discussion you will be researching named constants.  Give several reasons why using named constants can help the programmer be more efficient when changes need to be made.  For the response post, take a classmates post and give a possible issue that would arise using named constants.  Be sure to be in depth and justify your posts

## Response

```cs
const string name = "Jak Gadaleta";
```

constants provide a lot of power when writing code due to the fact that they never change. `name` will always consist of the name `"Jak Gadaleta"` so wherever in the application I need to put my name I can just include this new `name` constant. The other great part about constants is that I can always fix any mistakes and then re-compile the code. In this instance all I gotta do is go into my first line and change the spelling to `Jake Gadaleta` hit recompile and everywhere that the constant `name` is called in the application the spelling is now fixed.