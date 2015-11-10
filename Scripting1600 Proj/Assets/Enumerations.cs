using UnityEngine;
using System.Collections;

public class Enumerations : MonoBehaviour 
{
	public enum Direction{North, East, South, West};
	
	void Start ()
	{
		Direction myDirection = ReverseDirection(Direction.East);
		
		Debug.Log (myDirection);
	}
	
	Direction ReverseDirection (Direction dir)
	{
		if(dir == Direction.North)
			dir = Direction.South;
		else if(dir == Direction.South)
			dir = Direction.North;
		else if(dir == Direction.East)
			dir = Direction.West;
		else if(dir == Direction.West)
			dir = Direction.East;
		
		return (dir);
		
	
	}
}