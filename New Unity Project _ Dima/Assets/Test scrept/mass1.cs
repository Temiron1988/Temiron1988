using UnityEngine;
using System.Collections;

public class mass1 : MonoBehaviour {

	public int[] IntSize1 = new int[5];

	// Use this for initialization
	void Start () {


		for (int i = 0; i < 5; i++) {

			IntSize1[i] = Random.Range(1,10);

			print ("index int= "+i);
			print (" ="+IntSize1[i]);
		}
	



	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
