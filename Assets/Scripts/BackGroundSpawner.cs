using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundSpawner : MonoBehaviour {

	private GameObject[] backgrounds;
	private float lastYposition;


	// Use this for initialization
	void Start () 
	{
		
	}
	
	void getBackgroundAndsetLastY()
	{
		backgrounds = GameObject.FindGameObjectsWithTag("Background");

		lastYposition = backgrounds[0].transform.position.y;

		for (int i = 1; i < backgrounds.Length; i++)
		{
			if (lastYposition > backgrounds[i].transform.position.y)
			{
				lastYposition = backgrounds[i].transform.position.y;
			}
		}
	}

}
