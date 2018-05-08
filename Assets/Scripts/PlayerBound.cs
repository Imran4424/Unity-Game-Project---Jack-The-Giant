using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBound : MonoBehaviour {

	private float minX, maxX;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SetMinAndMax()
	{
		Vector3 bounds = Camera.main.ScreenToWorldPoint();
	}
}
