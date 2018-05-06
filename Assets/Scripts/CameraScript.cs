using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {


	private float speed = 1f;
	private float acceleration = 0.2f;
	private float maxSpeed = 3.2f;

	[HideInInspector]
	public bool movecamera;

	// Use this for initialization
	void Start () 
	{
		movecamera = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(movecamera)
		{
			moveCamera();
		}
	}

	void moveCamera()
	{
		Vector3 temp = transform.position;

		float oldY = temp.y;
		float newY = temp.y - (speed * Time.deltaTime);
	}
}
