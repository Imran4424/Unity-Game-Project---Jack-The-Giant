using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{

	[SerializeField]
	private GameObject[] clouds;

	private float distanceBetweenClouds = 3f;

	private float minX, maxX;

	private float lastCloudPositionY;

	private float controlX;

	private GameObject player;

	[SerializeField]
	private GameObject[] Collectables;

	void Awake ()
	{
		controlX = 0;
		setMinAndMaxX ();
		createClouds ();

		player = GameObject.Find("Player");
	}

	void Start()
	{
		positionThePlayer();
	}

	void setMinAndMaxX ()
	{
		Vector3 bounds = Camera.main.ScreenToWorldPoint (new Vector3 (Screen.width, Screen.height, 0));

		maxX = bounds.x - 0.5f;
		minX = -bounds.x + 0.5f;
	}

	void shuffle (GameObject[] ArrayToShuffle)
	{
		for (int i = 0; i < ArrayToShuffle.Length; i++)
		{
			GameObject temp = ArrayToShuffle[i];

			int random = Random.Range (i, ArrayToShuffle.Length);

			ArrayToShuffle[i] = ArrayToShuffle[random];
			ArrayToShuffle[random] = temp;
		}
	}

	void createClouds ()
	{
		shuffle (clouds);

		float positionY = 0f;

		for (int i = 0; i < clouds.Length; i++)
		{
			Vector3 temp = clouds[i].transform.position;

			//temp.x = Random.Range (minX, maxX);
			temp.y = positionY;

			if (controlX == 0)
			{
				temp.x = Random.Range (0.0f, maxX);

				controlX = 1;
			}
			else if (controlX == 1)
			{
				temp.x = Random.Range (0.0f, minX);

				controlX = 2;

			}
			else if (controlX == 2)
			{
				temp.x = Random.Range (1.0f, maxX);

				controlX = 3;
			}
			else if (controlX == 3)
			{
				temp.x = Random.Range (-1.0f, minX);

				controlX = 0;

			}

			lastCloudPositionY = positionY;

			clouds[i].transform.position = temp;

			positionY -= distanceBetweenClouds;
		}
	}

	void positionThePlayer()
	{
		GameObject[] darkClouds = GameObject.FindGameObjectsWithTag("Deadly");
		GameObject[] cloudsInGame = GameObject.FindGameObjectsWithTag("Cloud");

		for (int i = 0; i < darkClouds.Length; i++)
		{
			if (darkClouds[i].transform.position.y == 0)
			{
				Vector3 tempDarkCloud = darkClouds[i].transform.position;	

				darkClouds[i].transform.position = new Vector3( cloudsInGame[0].transform.position.x,
																cloudsInGame[0].transform.position.y,
																cloudsInGame[0].transform.position.z);

				cloudsInGame[0].transform.position = tempDarkCloud;
			}	
		}

		Vector3 playerTemp = cloudsInGame[0].transform.position;

		for (int i = 1; i < cloudsInGame.Length; i++)
		{
			if (playerTemp.y < cloudsInGame[i].transform.position.y)
			{
				playerTemp = cloudsInGame[i].transform.position;
			}	

			playerTemp.y += 0.8f;

			player.transform.position = playerTemp;
		}
	}

	void OnTriggerEnter2D(Collider2D target)
	{
		if (target.tag == "Cloud" || target.tag == "Deadly")
		{
			if (target.transform.position.y == lastCloudPositionY)
			{
				shuffle(clouds);
				shuffle(Collectables);
			}
		}	
	}
}