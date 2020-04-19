# MarsRover

The Rover, goes to the entered coordinates and moves with commands. A rover's position and location is represented by a combination of x and y co-ordinates and a letter
representing one of the four cardinal compass points. An example position might be 0 0 N, which means the rover is in the bottom
left corner and facing North.

The position is made up of two integers and a letter separated by spaces, corresponding to the x
and y co-ordinates and the rover's orientation.

## Directions
###### N: North <br/>
###### S: South <br/>
###### E: East <br/>
###### W: West <br/>

## Commands
###### L: Turn to Left <br/>
###### R: Turn to Right <br/>
###### M: Move <br/><br/>

The command "L" or "R" means is, makes the rover spin 90 degrees left or right respectively, without moving from its
current spot. 'M' means move forward one grid point, and maintain the same heading.

## Example
Input;
```
Enter coordinates...
1 2 N
Enter commands...
LMLMLMLMM
```

Output;
```
The rover's current coordinates: 1 3 N
```
