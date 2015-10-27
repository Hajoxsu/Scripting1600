using UnityEngine;
using System.Collections;

public class ArrayTest : MonoBehaviour 
{
	public GameObject[] players;
	// Use this for initialization
	void Start () 
	{
		players = GameObject.FindGameObjectsWithTag("Player");
		
		for(int i = 0; i < players.Length; i++)
		{
			Debug.Log ("Player Number " + " is named " + players[i].name);
		}
	}
}