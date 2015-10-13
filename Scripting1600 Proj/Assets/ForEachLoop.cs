using UnityEngine;
using System.Collections;

public class ForEachLoop : MonoBehaviour {


	void Start () {
		string[] strings = new string[3];

		strings [0] = "It is now October.";
		strings [1] = "Tons of candy is sold at stores.";
		strings [2] = "It's almost Halloween!";
	
		foreach (string item in strings) {
			print (item);
		}
	}
}
