using UnityEngine;
using System.Collections;

public class Mass1_3 : MonoBehaviour {

	public int Mas;

	// Use this for initialization
	void Start () {

		int[][] IntSize2dR = new int[Mas][];

		string str = "";

	
	for (int i = 0; i < Mas; i++) {
			IntSize2dR[i] = new int[Random.Range(1,4)];

			for (int j = 0; j < IntSize2dR[i].Length; j++) {
				IntSize2dR[i][j] = Random.Range (1,6);
				str+= IntSize2dR[i][j];
			}

			str+=("\n");
		}

		print (str);


	
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
