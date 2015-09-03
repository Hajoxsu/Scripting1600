using UnityEngine;
using System.Collections;

public class VariablesandFunctions : MonoBehaviour 
{
	int myInt = 8;

	void Start () 
	{
		MultiplyByTwo(myInt);
		Debug.Log (myInt);
	}
	int MultiplyByTwo(int number) {
		int ret;
		ret = number * 2;
		return ret;
	}
		
}