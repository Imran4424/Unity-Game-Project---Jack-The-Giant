﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBound : MonoBehaviour {

	private float minX, maxX;

	// Use this for initialization
	void Start () 
	{
		SetMinAndMax();	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (transform.position.x < minX)
		{
			Vector3 temp = transform.position;

			temp.x = minX;
			transform.position
		}	
	}

	void SetMinAndMax()
	{
		Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,0));

		maxX = bounds.x;
		minX = -bounds.x;
	}
}
