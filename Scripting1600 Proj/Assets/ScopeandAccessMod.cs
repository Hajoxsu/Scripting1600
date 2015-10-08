using UnityEngine;
using System.Collections;

public class ScopeandAccessMod : MonoBehaviour {

	public int alpha = 7;
	
	
	private int beta = 0;
	private int gamma = 5;
	
	
	private AnotherClass myOtherClass;
	
	
	void Start ()
	{
		alpha = 32;
		
		myOtherClass = new AnotherClass();
		myOtherClass.FruitMachine(alpha,myOtherClass.raspberries);
	}
	
	
	void Example (int pencils, int erasers)
	{
		int answer;
		answer = pencils * erasers * alpha;
		Debug.Log(answer);
	}
	
	
	void Update ()
	{
		Debug.Log("Alpha is set to: " + alpha);
	}
}