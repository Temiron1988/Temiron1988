using UnityEngine;
using System.Collections;

public class Hello : MonoBehaviour {

	// Use this for initialization
	void Start () {

		int a = 10;
		int b = 15;
		int c = 20;

		Debug.LogWarning ("Hello");

		print ("a=" + a + ";\n" + "b=" + b + ";\n");
		print ("c=" + c + ";");

	 	if (a > b && a > c) {
			print ("a = більше");
		}

		if (b > a && b > c) {
			print ("b = більше");
		}

		if (c > b && c > a) {
			print ("c = більше");
		}
		 
		if (a < b && a < c) {
			print ("a = меньше");
		}
		
		if (b < a && b < c) {
			print ("b = меньше");
		}
		
		if (c < b && c < a) {
			print ("c = меньше");
		}

		print ("kg = tonn");
		double a1 = 55358;
		double tonn = (a1 * 0.001);
		print (a1+"kg");
		print ((int)tonn + "tonn");
			
	}
	// Update is called once per frame
	void Update () {
	
	}
}
