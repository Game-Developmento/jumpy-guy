# Donald Duck Jump Game
Donald Duck Jump is a fun and challenging platformer game where you play as the beloved Disney character, Donald Duck. Your objective is to jump as high as possible while avoiding obstacles on the way. The game consists of three levels, each increasing in difficulty as you progress. The controls are straightforward, using the left and right arrow keys to move Donald Duck left or right.

[Click here to play the game!](https://orihoward.itch.io/donald-duck-jump-game)



## Levels
### Level 1
This is the basic level, designed for the player to learn the game's mechanics and physics. The platforms are easy to navigate, with no obstacles or enemies in the way.

### Level 2
The difficulty increases in Level 2, as the platforms are smaller and the bounces are lower. Some platforms move, and on each attempt, different platforms move. If the player falls, they have to start over from the beginning of the level.

### Level 3
In Level 3, the platforms are very small, and some of them have spikes. The player also needs to avoid shooting balls from the sides of the screen. This is the last level of the game, and if the player finishes it, they win the game.

## Scripts

*The game is made using the Unity engine and includes the following scripts*

### CameraFollow
This script is used to make the camera follow the player as they jump higher and higher on the platforms.

### Mover
This script is a basic mover component for the movement of the object, giving a velocity for an object in the game.

### ObjectSpawner
This script is used to spawn fireballs in Level 3. Each fireball spawns with a random time between a threshold and a random velocity.

### NextLevel
This script is used to load the next level scene.

### PlayerController
This script is attached to the player, allowing them to move, and handling the collision with other objects in the game.

### Platform
This script is attached to the platforms of each level, giving a jump force for the player. Each level has a different jump force value.

### SlideMovement
This script handles the slide movement of the platforms when they move left and right.

### GameManager
This script handles the restart game button to load Level 1.

*In addition to these scripts, there are two AutoAttach scripts*:

### DisableOnInvisible
This script is attached to all platforms and disables them when they are not visible on the screen.

### SlideRandom
This script handles the randomness of the platform slides, choosing randomly which platforms are going to slide in each attempt.

*The game uses Unity engine physics to provide a realistic jumping and bouncing experience.*
