# D.D.D.
Small Storytelling Game.

## Game Description
D.D.D. is a 2D game with simple an mechanics that come together to making a interesting interactive puzzle level where the story is created by the choices of the player. The game has a eerie vibe bus isn't scary in and of itself.  

  
## Inspiration
I always wanted to make a story telling game where you create the story by playing the game. This experience is supposed be a little eerie because the Player is told very little and is unable to fight enemies and can therefore only run and hide.

## Learning Goals

* Collision ignoring
* Reusable inventory and items
* Stats for characters and items
* Reusable enemy A.I. using a FSM

## Features
| Technique / Mechanic | Description | Status |
| ----- | ----- | ----- |
| Obstacles | objects the player can walk up to and hide. if the enemy is far enough it won't see you hide and return but if it did see you hide it'll keep chasing the player. | Done |
| Inventory and Items | Player can pick up Items and use these for example, keys, flash light and / or weapons | Done |
| locked Doors | A gate or door that requires the player to hold a specific item to open up | Done |
| 2nd Dimension | the player can activate a second "dimension" changing the layout of the level | In Development |
| Enemy AI | AI making enemies chase a player once it sees it and will stop once a player runs far enough or hides without the enemy spotting the player.        | Done |

#### Obstacles
The obstacles are simple objects that a player can walk up to to hide, the hiding will make the player harder to see and if not spotted by an enemy unnoticeable making the enemy walk straight past the player.
  
#### Inventory and Items
Throughout the levels items containing keys, tools and more will be placed these will be stored in the inventory and automatically used when necessary.
  
#### Locked Doors
Some doors will have a lock and can only be opened with the corresponding key, if the door is locked and the player walks up to it it'll display a hint message.
  
#### 2nd Dimension
When in a portal or using an item the player can gain the ability to move in a secondary dimension with different doors, enemies and items. this ability might be necessary at times to solve a level.
  
#### Enemy AI
The enemies need to have more than 2 brain cells and have the ability to spot the player and chase it, once far enough the enemy will lose the player and be unable to see is hide.

#### Inventory and Usable Items
I've made simple inventory scripts before nut that was always online console and text based. I wanted a system for picking up and using Items with specific stats working with the player stats. 

## Software Analysis  

### Unity  

Unity is an extremely user friendly engine made for beginners as well as experienced developers, Unity is more 2D focussed and had even got a separate compact engine for small 2D games but the 3D capabilities are really stunning as well. The engine compiles really fast so making small changes isn't a problem but as a project grows using the profiler and managing the garbage collector is essential. It has many tools and since the new update it's only gotten better and more powerful, good examples are the new rendering pipelines and shader graph for an easy way to create amazing shaders using nodes and unity also had a tool for node based programming. The UI is about as flexible as it gets but it can be a little restrictive with its simplicity but since Unity 2019.1 there is also UI Elements as a public API which allows developers to make the UI look any way they want. The components in unity are simple to use to make the implementation of collision extremely easy for both 2D and 3D, sound and GUI very easy to implement as well and once your project is ready to build you can build it for varying platforms with minimal to no changes. The biggest disadvantage of unity is the lack of documentation but there are a lot of people who are always able to help others like you and me.  

 
| Pro's | Con's |
| --- | --- |
| Quick and easy learning curve | Over simplified UI |
| Compiles really fast | some areas lack documentation |
| Build to many platforms | slow later in development |



### Unreal

Unreal is a powerful engine with a lot of freedom. The engine is a little harder to get started with for beginners because there are so many options but, because there are so many option experienced developers will have a lot more control and unreal also had great characteristics for the different types of graphics making it suitable some Triple-A games, the engine also has easy to use tools for artist and developers to use with little knowledge of the engine or programming at all, blueprints are a great feature to create some awesome scripts with visual coding. The engine is better for 3D than 2D and that really shows especially with physics and graphics. Epic Games (owners of the engine and Fortnite) makes a lot of money and uses it brings constant updated to the engine and new features as well, they also do weekly live streams and events for the community. 

| Pro's | Con's |
| --- | --- |
| Lots of flexibility and control | More difficult to start with |
| Great level design tools | Less online tutorials and documentation |
| Open source | smaller community |

### JavaScript

JavaScript is a great language to make simple 2d games on any browser, there is a huge community of developers and can be used is so many ways. Getting started is easy once you got your components but some mechanics are very difficult to make from scratch and for that you would most likely be better off using an API or library. The biggest disadvantage is that the code runs on the client side and the user can easily access the code locally but, there are way's to pre-compile the code so the code is a lot harder to edit, this also makes sure every browser reads the code the same making it work great on about every platform.

| Pro's | Con's |
| --- | --- |
| Simple and fast to learn and use | Security |
| Cross platform | Browser Interpretation |
| Excellent documentation and community | Rely on libraries |

### Why I picked Unity?

Unity has some benefits when you're working on a smaller game and financially as well. unlike the 5% cut (when profitable above $30.000~) of unreal engine, for unity you don't need to pay anything unless your game makes over $100.000, when this it the case you need to use the pro version which is not that expensive, gives you more features and is way cheaper than the amount most others engines take.

Unity is mainly focused on 2D games and has a separate engine which is extremely small, for this project I choose the full unity 3D engine for the possibility of adding 3D in the game to mix things up and give me as the developer more freedom to experiment with features.

The engine works with C# which is a scripted language meaning you can make minor changes while running the same but more importantly that the game builds really fast when developing, the other benefits of C# is that is does a lot of the memory management automatically unlike languages such as C++, this gives you less control but for most games this works perfectly fine and the only thing you need to really manage is the garbage collector with the free profiler tool.  

The biggest benefit by far when using unity is the gigantic community, whenever you hit a wall there's almost always a tutorial or form where you can find the answer to your problem. but to me Unity is the natural choice for a small game for its simplicity and the fact I have over 4+ years of experience with the engine. 
  


## Planning and organization
[Trello](https://trello.com/b/v16yD2Fl/ddd)  
[Documentation](https://github.com/MikeRaadsheer/DDD/tree/development/documentation/)  

## Tools and sources
[Trello](https://trello.com/)  
[Draw.io (_desktop_)](https://draw.io/)  
[Open Office 365](https://products.office.com/en/excel)  
[Gimp](https://www.gimp.org/downloads/)  
sound effects [FreeSound](https://freesound.org/)  

### Tutorials  

[Collision Ignoring](https://www.youtube.com/watch?v=MKjWDtm5eeU) for the hiding function.


## Project Specifications
Unity version: 2019.1.14f1