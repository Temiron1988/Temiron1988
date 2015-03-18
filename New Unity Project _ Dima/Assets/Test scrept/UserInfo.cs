using UnityEngine;
using System.Collections;

public class adress 
{

	public string street;
	public int house;


	}

public class UserInfo1 : adress
{
	public string name;
	private string sex;
	public string sex1 {
		set {
			if (value == "male" || value == "female")
			sex = value;
			else
				sex = "your sex is false";
		}
		get{
			return sex;
		}
	}
	private int age;
	public int age1 {
		set{
			if (value<=0 || value>=120)
				age = 12;
			else
				age = value;
		}
		get{
			return age;
		}

	}

	public void PPrint(string val)
	{
		switch (val)
		{
			case "name":
			{Debug.Log ("name= " + name);
				break;}
			case "sex":
			{Debug.Log ("sex= " + sex);
			break;}
			case "age":
			{Debug.Log ("age= " + age);
			break;}
		}
	}

	public UserInfo1 (string setName, string setSex, int setAge)
	{

		name = setName;
		sex = setSex;
		age = setAge;

	}
	public UserInfo1 ()
	{
		
		name = "";
		sex = "";
		age = 1;
		
	}
}





public class UserInfo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		UserInfo1 unit2 = new UserInfo1 ("ira", "Male", 30);

		unit2.PPrint ("name");
		unit2.PPrint ("sex");
		unit2.PPrint ("age");


		UserInfo1 user1 = new UserInfo1 ();

		user1.name = "Dima";
		user1.sex1 = "egb";
		user1.age1 = 130;

		user1.PPrint ("name");
		user1.PPrint ("sex");
		user1.PPrint ("age"); 

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
