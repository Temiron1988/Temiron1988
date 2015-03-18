using UnityEngine;
using System.Collections;

public class mass1_2 : MonoBehaviour 
{

	int[,] IntSize2d = new int[3,5]; 

	// Use this for initialization
	void Start ()
	{
		string str = "";

		for (int x= 0; x < 3; x++) 
			{
			for (int y= 0; y < 5; y++)
				{
				IntSize2d[x,y] = Random.Range(0,10);
				str+=IntSize2d[x,y] + " ";
				}
			str+="\n";
			}

		print (str);

	}

		

	
	// Update is called once per frame
	void Update () {
	
	}
}
