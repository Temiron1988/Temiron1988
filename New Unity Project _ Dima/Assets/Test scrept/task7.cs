using UnityEngine;
using System.Collections;

public class task7 : MonoBehaviour {

	// Use this for initialization
	void Start () {

		int aFor = Random.Range (3, 10);
		int b = 0;

		for (int i = 0; i < aFor; i++) {
	
			int a = Random.Range(0,99);
				
			print ("a"+a);


				if (a % 2==0){
				b++;
			}

		}
		print (b);
	
	}
	
	// Update is called once per frame
	void Update () {



	}
}
