using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
	float x;
	float y;
	public float speed;
	// Use this for initialization
	void Start () 
	{

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
	}
}
