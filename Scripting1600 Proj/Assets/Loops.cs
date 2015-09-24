using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour {
	//This is a For Loop.
	int numEnemies = 4;
	
	void Start () {
		for(int i = 0; i < numEnemies; i++) 
		{
			Debug.Log("Creating enemy number" + " " + i);
		}
	}

}
