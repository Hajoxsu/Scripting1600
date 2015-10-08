using UnityEngine;
using System.Collections;

public class AnotherClass : MonoBehaviour {

	public int raspberries;
	public int strawberries;
	
	
	private int sharpener;
	private int tape;
	
	
	public void FruitMachine (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log("Fruit total: " + answer);
	}
	
	
	private void OfficeSort (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log("Office Supplies total: " + answer);
	}
}
