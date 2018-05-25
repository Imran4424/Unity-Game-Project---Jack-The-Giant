using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
	public static PlayerScore instance;

	[SerializeField]
	private AudioClip coinClip, lifeClip;

	private CameraScript cameraScript;

	private Vector3 previousPosition;
	private bool count_Score;

	public static int scoreCount;
	public static int lifeScoreCount;
	public static int coinScoreCount;

	void Awake ()
	{
		cameraScript = Camera.main.GetComponent<CameraScript> ();
		MakeInstance ();
	}

	void MakeInstance ()
	{
		if (instance == null)
		{
			instance = this;
		}
	}

	// Use this for initialization
	void Start ()
	{
		previousPosition = transform.position;
		count_Score = true;
	}

	public void setScore (int score)
	{
		scoreCount = score;
	}

	public void setCoin (int coin)
	{
		coinScoreCount = coin;
	}

	public void setLife (int life)
	{
		lifeScoreCount = life;
	}

	// Update is called once per frame
	void Update ()
	{
		countScore ();
	}

	void countScore ()
	{
		if (count_Score)
		{
			if (transform.position.y < previousPosition.y)
			{
				scoreCount++;
			}

			previousPosition = transform.position;

			GamePlayController.instance.setScore (scoreCount);
		}
	}

	void OnTriggerEnter2D (Collider2D target)
	{
		if (target.tag == "Coin")
		{
			coinScoreCount++;

			scoreCount += 200;

			GamePlayController.instance.setCoinScore (coinScoreCount);
			GamePlayController.instance.setScore (scoreCount);

			AudioSource.PlayClipAtPoint (coinClip, transform.position);
			target.gameObject.SetActive (false);
		}

		if (target.tag == "Life")
		{
			lifeScoreCount++;
			scoreCount += 300;

			GamePlayController.instance.setLifeScore (lifeScoreCount);
			GamePlayController.instance.setScore (scoreCount);

			AudioSource.PlayClipAtPoint (lifeClip, transform.position);
			target.gameObject.SetActive (false);
		}


		if (target.tag == "Deadly" || target.tag == "Bounds")
		{
			cameraScript.movecamera = false;
			count_Score = false;

			transform.position = new Vector3 (500, 500, 0);

			//Debug.Log ("PlayerScore before decrement life = " + lifeScoreCount);

			lifeScoreCount--;

			//Debug.Log ("PlayerScore before decrement life = " + lifeScoreCount);

			GameManager.instance.CheckGameStatus (scoreCount, coinScoreCount, lifeScoreCount);
		}
	}
}