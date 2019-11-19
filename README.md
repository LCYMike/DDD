# D.D.D.
Small Storytelling Game

## Game Description
D.D.D. is a game where you follow someone trough their live and see how it starts and ends.  
Some stories can be sad and unfair while others are just your average old man who just got old but didn't have the best ending.  

## Learning Goals
| Technique / Mechanic | Description | Status |
| ----- | ----- | ----- |
| Obstacles | objects the player can walk up to and hide. if the enemy is far enough it won't see you hide and return but if it did see you hide it'll keep chasing the player. | Done |
| Inventory and Items | Player can pick up Items and use these for example, keys, flash light and / or weapons | Done |
| locked Doors | A gate or door that requires the player to hold a specific item to open up | Done |
| 2nd Dimension | the player can activate a second "dimension" changing the layout of the level | In Development |
| Enemy AI | AI making enemies chase a player once it sees it and will stop once a player runs far enough or hides without the enemy spotting the player.        | Done |

#### Obstacles
The obstacles ar simple objects that a player can walk up to to hide, the hiding will make the player harder to see and if not spotted by an enemy unnoticeable making the enemy walk straight past the player.
  
#### Inventory and Items
Troughout the levels items containing keys, tools and more will be places these will be stored in the inventory and automatically used when necessary.
  
#### Locked Doors
Some doors will have a lock and can only be opened with the corrisponding key, if the door is locked and the player walks up to it it'll display a hint message.
  
#### 2nd Dimension
When in a portal or using an item the player can gain the ability to move in a secondairy dimension with different doors, enemies and items. this ability might ne secessary at times to solve a level.
  
#### Enemy AI
The enemies need to have more than 2 brain cells and have the ability to spot the player and chase it, once far enough the enemy will lose the player and be unable to see is hide.
  
## Inspiration
I always wanted to make a story telling game about someone who is in this dreadful situation...  
A pit of despair. Someone who can't fight back but only run and hide.  
I want to make a game that makes you the player decide the story.  
Depending on those choises good things can happen and it can all disappear.  
This experience is supposed be very grim and unsaturated.  

## Software Analysis  


### Unity  

Unity is an extremely user friendly engine made for beginners as well as experienced developers, the engine compiles really fast so making small changes isn't a problem but as a project grows using the profiler and managing the garbage collector is essential. It has many tools and since the new update it's only gotten better and more powerfull, good examples are the new rendering pipelines and shader graph for an easy way to create amazing shaders using nodes and unity also had a tool for node based programming. the UI is about as flexible as it gets but it can be a little restrictive with it's simplicity but since Unity 2019.1 there is also UIElements as a public API which allowes developers to make the UI look any way they want. The components in unity are simple to use to make collision, sound and GUI very easy to implement. Once your project is ready to build you can build it for varying platforms with minimal changes. the biggest disatvantage of unity is the lack of documentation but there are a lot of people who are alway's able to help others like you and me.  

 
| Pro's | Con's |
| --- | --- |
| Quick and easy learning curve | Over simplified UI |
| Compiles really fast | some areas lack documentation |
| Build to many platform | slow later in development |



### Unreal

Unreal is a powerful engine with a lot of freedom. The engine is a little harder to get started with for beginners because there are so many options but, because there are so many option experienced developers will have a lot more control and unreal also had great characteristics for the different types of graphics making it suitable some Triple-A games, the engine also has easy to use tools for artist to use with little knowledge of the engine. Epic Games (owners of the engine and Fortnite) makes a lot of money and uses it bring constant updated to the engine and new features as well, they also do weekly livestreams and events for the community. 

| Pro's | Con's |
| --- | --- |
| Lot's of flexibility and control | More difficult to start with |
| Great level design tools | Less online tutorials and documentation |
| Open source | smaller community |

### JavaScript

Javascript is a graet language to make simple 2d games on any browser, there is a huge community of developers and can be used is so many ways. Getting started is easy once you got your components but some mechanics are very difficult to make from scratch and for that you would most likely be better off using an API or library. the biggest disatvantage is that the code runs on the client side and the user can easily access the code locally but, there are way's to precompile the code so the code is a lot hardder to edit, this also makes sure every browser reads the code the same making it work great on about every platform.

| Pro's | Con's |
| --- | --- |
| Simple and fast to learn and use | Security |
| Cross platform | Browser Interpretation |
| Excellent documentation and community | Rely on libraries |

### Why I picked Unity?

Unity has some benefits when you're working on a smaller game and financially as well. unline the 5% cut (when profitable aboke $30.000~) of unreal engine, for unity you don't need to pay anything unless your game makes over $100.000, when this it the case you need to use the pro version which is not that expencive, gives you more features and is way cheaper than the ammout most others engines take. The engine works with C# which is a scripted language meaning you can make minor changes while running the same but more importantly that the game builds really fast when developing, the other benefits of C# is that is does a lot of the memory management automatically unlike languages such as C++, this gives you less control but for most games this works perfectly fine and the only thing you need to really manage is the garbage collector with the free profiler tool.  

The biggest benefit by far when using unity is the gigantic community, whenever you hit a wall there's almost alway's a tutorial or form where you can find the answer to your problem. but to me Unity is the natural choice for a small game for it's simplicity and the fact I have over 4+ years years of experience with the engine. 
  


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