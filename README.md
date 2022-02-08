# flappybirddemo
This is a Unity3D project but I can only upload the C# files here. This is a porfolio project for the subject Tech for Good of Skill Bootcamp In Digital
with Manchester Metropolitan University.

I am glad to get a full mark for this project. The comment from my lecturer:

Grade	100.00 / 100.00

Graded on Monday, 20 December 2021, 3:29 PM

Graded by Connah Kendrick

Games Design 30 / 30
Games Implementation 40 / 40
Reflection 30 / 30

Comment: Very strong reflection you demonstrate good working knowledge of both unity and games design. 
You’ve take the opportunity to really delve into what it take to become good in game design by going out and 
try new things like the explosion animation and add new levels, if you would like any advice on this feel free drop me an email. 
The game runs well in a level design way and the introduction of power ups is very well done, the introduction cinematic is made very well. 
This is the best version of the assignment I have seen yet.


My Report:

0. Introduction

This report is about how I modify an existing Flappy Bird game files in Unity with my
new ideas. Moreover, I tried to apply most of the skills from software application of
Unity to C# coding that I have learnt in this Bootcamp course to reflect what I have
learnt. Furthermore, I have also done some research in Google to solve problems that I
met while I was developing the game.

1. Game Design Process

The features I have added to the games are:
- An opening animation for gameplay instruction and a brief game story.
- One pipe in the looping pipes is generated randomly with Position X and Y
- A “Power Up” capsule could help players to destroy the first pair of pipes if they
can catch it

As I am keen on story oriented games, I think an opening animation could help players
to immerse into the game. Besides, a brief gameplay instruction is necessary for players
on how to play the game properly. Moreover, random elements in the game could bring
challenges to players and extend the time they enjoy a game.

2. Game Development Process

By creating an opening animation, I have used the animation function and a script at the
end of the timeline to start the gameplay after the animation is played.

```
Random.Range(-0.5f, 0.5f),pipe.transform.position.y + Random.Range(-2.0f, 2.0f), pipe.transform.position.z);
```

Moreover, I have found a random method of Unity on the web that it could generate a
range of numbers so a pipe will be generated a bit different with position whenever the
pipes are looped to exist.

```
if ( collision.gameObject.tag == "score")
        {
            gameObject.SetActive(false);
            transform.parent.Find("Pipes0").gameObject.SetActive(false);
            powerSound.Play();
            transform.parent.Find("Explosion").gameObject.SetActive(true);
            explodeSound.Play();
        }
```

For the feature to destroy pipes, I used the code to turn the specific pipes to be inactive
when players collide a “Power Up” capsule. Then the sound effect of power up and
explosion and an explosion animation will play.

```
transform.Find("Capsule").gameObject.SetActive(true);
transform.Find("Pipes0").gameObject.SetActive(true);
transform.Find("Explosion").gameObject.SetActive(false);
```

The looping pipes function has code to turn the specific pipes to be active, so they could
exist again after being destroyed. Besides, the explosion animation will be set to
inactive, so they could be triggered again when players get the capsule.

```
transform.parent.GetComponent<SideScroller>().xSpeed = 0;
transform.parent.Find("gameover").gameObject.SetActive(true);
hitSound.Play();
this.gameObject.SetActive(false);
```

When it is gameover, SetActive of the GameObject controlling the gameplay will be false
so players cannot take anymore action.

3. Self-reflection on Game Development

For the basic requirement for looping the pipes, I think the code which is taught in the
class by detecting distance between two objects and bringing them closer is a simple
and useful method. Besides, the code triggered at the end of animation could help me
to create a cinematic experience for players. Moreover, the random method can help
me easily to enhance challenges in the game, and it could be utilized in many parts of
the game for editing different attributes. In addition, I used the 2D physics for the
“Power Up” capsule, so this can be a bit challenging for players to catch it. On the other
hand, the most struggling part for me is the creation of a “Power Up” item for players to
destroy the pipes. I have tried using the Destroy syntax to eliminate the pipe but the
pipe object will be removed ever, so I changed the pipe object to be inactive instead.
Therefore, when the pipes are looped, the eliminated pipe will exist again. Otherwise, I
have used a free asset from Unity asset store to make the explosion animation effect
https://assetstore.unity.com/packages/2d/textures-materials/2d-flat-explosion-66932.

4. Self-reflection on Future Improvements

Firstly, I would try to edit that a player could destroy any of the pipes after they catch
the “Power Up” capsule. I guess this could be achieved by defining the state of each pipe
to be destroyable or not. Secondly, I would challenge myself to make a boss fight at the
end of the game, so if players could evade a number of objects thrown by the boss then
they would defeat the boss. Therefore, the game will look more like a completed
product. Finally, I would also like to apply a Sci-fi aesthetics and story setting to adapt
the game, so the player will control a spaceship flying through the meteoroids.
