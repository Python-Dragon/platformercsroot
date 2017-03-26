using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
	 float x;
	 float y;
	public float speed;
	public float grav;
	public float strength;
	float gravh;
	// Use this for initialization
	void Start () 
	{
		gravh = grav;
	}
	
	// Update is called once per frame
	void Update () {
		y = transform.position.y;
		x = transform.position.x;
		//Debug.Log (x);
		if (Input.GetKey(KeyCode.D) == true) 
		{
		//	Debug.Log ("hi");
			transform.position = new Vector2(x + speed, y);
		//	Debug.Log("there");
		}
		if (Input.GetKey (KeyCode.A) == true) 
		{
			transform.position = new Vector2 (x - speed, y);
		}
		// this is a test platform
		if (x < 100 && x > -100 && y > -10 && y < -1) {
			grav = 0;
		} else {
			grav = gravh;
		}


	}
	void FixedUpdate() 
	{
		// this is gravity code
		Debug.Log (y);
		transform.position = new Vector2 (x, y - grav);
		// this is jump code
		if (Input.GetKey (KeyCode.W) == true) {
			transform.position = new Vector2 (x, y + strength);
		}

	
	}

}
