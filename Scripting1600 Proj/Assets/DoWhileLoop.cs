using UnityEngine;
using System.Collections;

public class DoWhileLoop : MonoBehaviour {


	void Start () {
		bool ShouldContinue = false;

		do {
			print ("I see you!");
		} while(ShouldContinue == true);
	}
}
