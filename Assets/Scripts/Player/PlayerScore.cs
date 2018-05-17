using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour {

	[SerializeField]
	private AudioClip coinClip,lifeClip;

	private CameraScript cameraScript;

	private Vector3 previousPosition;
	private bool count_Score;

	public static int scoreCount;
	public static int lifeScoreCount;
	public static int coinScoreCount;

	public bool moveCamera;

	void Awake()
	{
		cameraScript = Camera.main.GetComponent<CameraScript>();
	}	
	// Use this for initialization
	void Start () 
	{
		previousPosition = transform.position;
		count_Score = true;
		scoreCount = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		countScore();	
	}

	void countScore()
	{
		if (count_Score)
		{
			if (transform.position.y < previousPosition.y)
			{
				scoreCount++;
			}

			previousPosition = transform.position;
		}
	}

	void OnTriggerEnter2D(Collider2D target)
	{
		if (target.tag == "Coin")
		{
			coinScoreCount++;

			scoreCount += 200;

			AudioSource.PlayClipAtPoint(coinClip,transform.position);
			target.gameObject.SetActive(false);
		}
	}
}
