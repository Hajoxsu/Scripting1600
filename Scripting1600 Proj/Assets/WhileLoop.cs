using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour {


	int catsInTheGround = 3;

	void Start () 
	{
		while(catsInTheGround > 0)
		{
			Debug.Log("I've buried a cat!");
			catsInTheGround--;
		}
	}
}