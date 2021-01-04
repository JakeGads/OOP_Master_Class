# In Short

VS Code and VS are different products each with their own strengths and weaknesses. When it comes to portability and extensibility VS code defiantly takes the cake.

(this is also mirrored below because its kinda a long post)
## VS Code

For starters I love VS code, I use it in the day to day as a general text editor, I write a lot of python, javascript, Java, and Markdown its pretty great. Even this version of VS has sub versions and I often stick with the OSS (Open Source Software) version of the project. The main strengths of VS Code comes from the fact that it built on top of a hyper optimized version of the java script library electron. Electron basically works by opening a small internal web browser to render everything, this allows Vs Code to run nearly everywhere you wanna run it on Mac just install the dmg, Linux its available as an app image, deb, or binary package, and an exe for windows. But this portability goes so much further, alongside Microsoft's acquisition of Github they built a new product called CodeSpaces, that let you code in the browser as well, read more about it [here](https://code.visualstudio.com/docs/remote/codespaces). The other great strength that comes with the fact that this is a javascript project is that its really easy to write extensions for this, Github (prior to being owned by Microsoft) worked on a similar system called atom, but VS codes being built on and originally for TypeScript made it really easy to build these extensions. People have done some really fun stuff with extensions Ben Awad, a code centric YouTuber, has made [Stories](https://www.youtube.com/watch?v=ApR-kNXxLUs), a parody of Snapchat and Instagram's feature, and [VS Tinder](https://www.youtube.com/watch?v=bfd8RyAJh6c) a rip on the tinder model but for code. As another note he also made an explanation on [how to make them as well](https://www.youtube.com/watch?v=a5DX5pQ9p5M)

VS code is an entirely different beast compared to the rest VS family, the others are kinda built on top of each other but because of the Electron aspect VS Code shares little no similarities 

## VS for Mac

This may be a shocker but this version of VS only runs on Mac OS. This version provides two frameworks to work on different application stacks Xamarin, for cross platform mobile development (Android and iOS), and .Net (framework & core) for web development. This version will get the job done for most developers, but unfortunately not for this class. As a side note you cna also use it for your C++ projects if you are into that. It again brings the ability to have extensions but these extensions need to be written in .NET and the community hasn't written as much for this version as they have for code.

## VS Community Edition

This is the version that we will be using for this class, It only runs on windows systems (older versions are compatible with WINE on Linux). It again is a .NET application with access to a truly shocking number of frameworks and languages. Ontop of having access to the frameworks provided by VS for Mac you can also generic python, iron python, WPF, node js, deno js, thats just scratching the surface. Yet again this is extensible, every non-Microsoft (we'll get to that later) extension is free to use and range from language frameworks to addition templates and git visualization. This is also the base line version for the following 2.

## VS Professional Edition

This is built on the last one with the cavitate that it absolutely only works on Windows. This is built for small teams, it comes with some Microsoft Azure git repos it also includes a CodeLens feature which allows you to examine git difference in VS itself

## VS Enterprise Edition

So including everything that comes with the above plus 

```bash
Integrated Development Environment

    Live Dependency Validation
    Architectural Layer Diagrams 
    Architecture Validation 
    Code Clone

Advanced Debugging and Diagnostics

    IntelliTrace
    Code Map Debugger Integration
    .NET Memory Dump Analysis

Testing Tools

    Live Unit Testing
    IntelliTest
    Microsoft Fakes (Unit Test Isolation)
    Code Coverage
```

which I [found here](https://www.tektutorialshub.com/visual-studio/difference-between-visual-studio-2019-community-vs-professional-vs-enterprise/#visual-studio-2019-professional-vs-community)


# In Short

VS Code and VS are different products each with their own strengths and weaknesses. When it comes to portability and extensibility VS code defiantly takes the cake.