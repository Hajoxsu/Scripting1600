using UnityEngine;
using System.Collections;

public class Variableandfunctions : MonoBehaviour 
	{
	int myInt = 8;
	void Start ()
	{
		myInt = dividebytwo (myInt);
		Debug.Log (myInt);
	}
	int dividebytwo (int number)
	{
		int ret;
		ret = number - 6;
		return ret;
	}



	}