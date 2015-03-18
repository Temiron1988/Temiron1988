using UnityEngine;
using System.Collections;


public class Play_perfab : MonoBehaviour {

	public GameObject[] obj;

	float timer = 0;

	public static int score = 0;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
		timer += Time.deltaTime;
	
		int x = Random.Range (-10,10);
		int y = Random.Range (-7,7);
		int z = Random.Range (0,8);

		int RandId = Random.Range (0,4);



		if (timer > 2) {

			Instantiate (obj[RandId], new Vector3 (x, y, z), new Quaternion (0,0,0,0));

			timer = 0;


		}

	}
}
