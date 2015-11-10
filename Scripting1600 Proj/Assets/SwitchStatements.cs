using UnityEngine;
using System.Collections;

public class SwitchStatements : MonoBehaviour {
	public int intelligence = 5;

	void Greet () 
	{
		switch (intelligence)
		{
		case 5:
			print("Well good day! Let me teach you about the solar system!");
			break;
		case 4:
			print("Hello! How are you?");
			break;
		case 3:
			print("Wuz up?");
			break;
		case 2:
			print("Bane smash!");
			break;
		case 1:
			print("Wockie wock wock sock");
			break;
		default: 
			print("Incorrect intelligence level.");
			break;
		}
	}

	void Update ()
	{
		Debug.Log (intelligence);
	}
}


