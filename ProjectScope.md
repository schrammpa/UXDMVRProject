### Project Scope / GDD 
Caroline Kendrick
Paul Schramm 
Talha Almanya

## City Destructor 

#### 1. Overview
*1.1 Project Summary*
City Destructor: A sandbox godzilla-like destruction game. Players take the form of a giant monster, and cause as much damage to a level. 

*1.2 About this document*


#### 2. Requirements 
*2.1 Hardware*
Oculus Rift S and Rift S Controllers 

*2.2 Software*
Unity 3D 2020.3.19f

#### 3. Gameplay 
*3.1 Summary* 
Players are dropped into a level 

*3.2 Movement*
 Move by bringing the controller in front of the body, holding a button and then dragging the controller alongside the body. This type of movement can be seen in the game [Gorn](https://store.steampowered.com/app/578620/GORN/).

*3.3 Interactions*
User can pick up buildings and other parts of the city, carry them, and throw them around. User can swipe with hand(s) to knock down parts of city. 
(if time: User can trigger an eye laser for (five?) seconds, which will set fires and be able to cut/slice objects as they move their head

*3.3 Destruction* 
Thrown/knocked over objects collide with each other topple with domino-like effects.

    Remaining Major Considerations: 
    Player v. Environment scale (I'm kind of hoping this will work itself out by us getting into VR w/ buildings and seeing what feels right) 
    Environment Bounds: How big is the world? What happens when godzilla runs into an edge? What does the edge of the city look like? Is there a way to generate the city without an edge ( seems like a good way to make the player walk into a wall, but you know ) 
    
#### 4. Visuals & Sound 
    references for visual feel: [Katamari Damacy](https://www.youtube.com/watch?v=BAtuIRy2mL4) & [Giant Cop](https://store.steampowered.com/app/451080/Giant_Cop_Justice_Above_All/)

*4.1 Player Character*
Game is played in first person, user does not see their body but sees their clawed monster hands. 

*4.2 City Components* 
*4.2.1 Static*
- Skyscrapers - several models, color swapping
- Smaller buildings/houses - several models, color swapping
- Designated buildings like town hall, bank, etc. - include depending on models found.

`depending on what we find/build - it could be fun to include a 'daily planet' type building with a sculptural compenent that could be rolled/thrown.`

*4.2.2 Animated*

    Katamari Damacy could also be a good reference for movement- especially the walking animations or lack of for people/animals. We could lean into a toy-box type of feel where thinks don't really move naturally.

- People - several models, color swapped. Animation: move on set paths on sidewalks, across roads, and into/out of buildings. (if time to implement: flee when player character gets to a certain distance from them)
- Birds (pigeons) Animation: Move on set paths through the sky at and around head height of player. Likely too small for player to grab.
- Planes, Helicopters. Animation: Move on set paths through the sky, above head height of player. Player able to catch and throw. 
- Cars/Trucks - several models, color swapped. Animation: move on set paths on city roads. (If time to implement: flee from player character) 

*4.3 User Interface*
need wire-frames:
- start screen 
- time's up screen 
- destructo-meter, in-game components

*4.4 Sound Effects*
 TBD
*4.5 BGM*
TBD

#### 5 . Timeline 
*5.1 Course Milestones* 
| Deliverable | Date |
|----------|--|
| Proof of Concept | 26 Nov |
| Usability Test | 30 Nov & 1 Dec |
| Usability Test Results (Hand in)  | 10 Dec |
| Code Freeze | 23 Dec  |
| Hand in Documentation | 16 Jan |
| Presentation | Feb |

*5.2 Work Timeline*
| Week  | Goals | Relevant Milestone |
|--|--|--|
| Nov 8 - Nov 13 | select final models for city and player, build city block, design user interface, complete GDD |
| Nov 15 - Nov 20| player able to move, pick up, and throw buildings, building collision, implement timer and accompanying UI |
| Nov 22 - Nov 27| complete and demonstrate proof of concept | Proof of Concept Nov. 26|
| Nov 29 - Dec 4| create larger city, animate moving city parts, add sound effects. Conduct, document, evaluate usability tests | Conduct Usability Tests 30 Nov & Dec 1|
| Dec 6 - Dec 11| evaluate and 'size' usability test insights, add destruction details (particles/ tweak collisions), add fire |
| Dec 13 - 17 | implement usability test insights, clean up product, start/end screens, add eye laser if time  |
| Dec 20 - 24 | clean up product, final touches, drink beer |Code Freeze 23 Dec |

    Notes: 
    	'Proof of Concept' should be base components. In a small city block, Player can destroy buildings. I'm assuming a learning curve here ... Once we have these base elements, we can expand them (i.e. we could just tile and rotate the same city block to make a larger city ) Are we doing usability tests with the proof of concept? 

#### Work Packages 

Talha:

Paul: 

CG: documentation, logo/menu/interface design, interface animation, 'level design'. find open-source sound effects, bgm. 

#### Change Log 
