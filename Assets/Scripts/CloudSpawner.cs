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



	void Awake()
	{
		setMinAndMaxX();
	}
	
	void setMinAndMaxX()
	{
		Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,0));

		maxX = bounds.x - 0.5f;
		minX = -bounds.x + 0.5f;
	}

	void shuffle(GameObject[] ArrayToShuffle)
	{
		for(int i=0; i < ArrayToShuffle.Length ; i++)
		{
			GameObject temp = ArrayToShuffle[i];

			int random = Random.Range(i,ArrayToShuffle.Length);

			ArrayToShuffle[i] = ArrayToShuffle[random];
			ArrayToShuffle[random] = temp;
		}
	}

	void createClouds()
	{
		shuffle(clouds);

		float positionY = 0f;

		for(int i=0; i < clouds.Length; i++)
		{
			Vector3 temp = clouds[i].transform.position;

			temp.x = Random.Range(minX,maxX);
			temp.y = positionY;

			lastCloudPositionY = positionY;

			clouds[i].
		}
	}
}
