using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour {

	[SerializeField]
	private GameObject[] clouds;

	private float distanceBetweenClouds = 3f;

	private float minX, maxX;

	private float lastCloudPositionY;

	private float controlX;

	private GameObject player;

	[SerializeField]
	private GameObject[] Collectables;


	// Use this for initialization
	void Start () {
		
	}
	
	void setMinAndMaxX()
	{
		Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,0));
	}
}
