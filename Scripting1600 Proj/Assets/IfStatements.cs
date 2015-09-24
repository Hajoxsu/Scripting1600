using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour {
	public float TooSlowSpeed = 65f;
	public float TooFastSpeed = 75f;
	public float carSpeed = 0f;

	// Use this for initialization
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space))
			SpedTest ();
		carSpeed += Time.deltaTime * 5f;
	}
	
	// Update is called once per frame
	void SpedTest () {
		if (carSpeed > TooFastSpeed) {
			print ("Too fast! Slow Down!");
		}
		else if (carSpeed < TooSlowSpeed){
			print ("Too slow! Speed up!");
		}
		else {
			print ("Good Speed! Keep going!");
		}
	}
}