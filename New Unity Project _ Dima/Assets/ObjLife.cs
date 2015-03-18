using UnityEngine;
using System.Collections;

public class ObjLife : MonoBehaviour {

	float timer = 0;
	int x = Random.Range (3, 20);
	Vector3 v1; 


	// Use this for initialization
	void Start () {
		v1 = new Vector3 (Random.Range (-0.01f, 0.01f),Random.Range (-0.01f, 0.01f),Random.Range (-0.01f, 0.01f));
	}
	
	// Update is called once per frame
	void Update () {


		transform.position += v1;

		timer += Time.deltaTime;

		if (timer > x) {
		
			Play_perfab.score -= 3;
			print(Play_perfab.score);

			Destroy (gameObject);

		}


	} 
	void OnMouseDown(){
	
		Play_perfab.score += 1;
		print(Play_perfab.score);
		
		Destroy (gameObject);
	
	}

}
