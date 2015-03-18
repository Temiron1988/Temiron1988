using UnityEngine;
using System.Collections;

public class SumVidXdoY : MonoBehaviour {
	public int x = 10;
	public int y = 1;

	// Use this for initialization
	void Start () {

		int sum = 0;

		for (int c = y; c < x; c++) {
			sum = sum + c;	
			}
		print (sum);	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
