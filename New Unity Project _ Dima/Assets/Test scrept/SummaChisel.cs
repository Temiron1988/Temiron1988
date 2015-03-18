using UnityEngine;
using System.Collections;

public class SummaChisel : MonoBehaviour {

	// Use this for initialization
	void Start () {

		int a = 1111;

		int sum1 = a / 1000;
		int sum2 = ((a - (a/1000*1000))/100);
		int sum3 = (a - ((sum1 * 1000) + (sum2 * 100)))/10;
		int sum4 = (a - ((sum1 * 1000) + (sum2 * 100) + (sum3 * 10)));

		int SumAll = sum1 + sum2 + sum3 + sum4;

		print (sum1);
		print (sum2);
		print (sum3);
		print (sum4);

		print (SumAll);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
