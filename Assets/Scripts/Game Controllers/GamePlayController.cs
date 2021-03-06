﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamePlayController : MonoBehaviour
{

	public static GamePlayController instance;

	[SerializeField]
	private Text scoretext, cointext, lifetext, gameOverscoretext, gameOvercointext;

	[SerializeField]
	private GameObject pausepanel, gameOverpanel;

	[SerializeField]
	private GameObject readyButton;

	void Awake ()
	{
		makeInstance ();

		//positionThePlayer ();
	}

	void Start ()
	{
		Time.timeScale = 0f;
	}

	void makeInstance ()
	{
		if (instance == null)
		{
			instance = this;
		}
	}

	public void gameOvershowPanel (int finalscore, int finalcoin)
	{
		gameOverpanel.SetActive (true);
		gameOverscoretext.text = finalscore.ToString ();
		gameOvercointext.text = finalcoin.ToString ();

		StartCoroutine (gameOverLoadMainMenu ());
	}

	// co-routine for waiting 3 seconds and then load main menu
	IEnumerator gameOverLoadMainMenu ()
	{

		yield return new WaitForSeconds (3f);

		SceneManager.LoadScene ("MainMenu", LoadSceneMode.Single);
	}

	public void RestartTheGame()
	{
		StartCoroutine(playerDiedRestart());
	}

	IEnumerator playerDiedRestart ()
	{
		yield return new WaitForSeconds (1f);

		SceneManager.LoadScene ("Gameplay", LoadSceneMode.Single);
	}

	public void setScore (int score)
	{
		scoretext.text = score.ToString ();

		PlayerScore.instance.setScore(score);
	}

	public void setCoinScore (int coinscore)
	{
		cointext.text = coinscore.ToString ();

		PlayerScore.instance.setCoin(coinscore);
	}

	public void setLifeScore (int lifescore)
	{
		lifetext.text = lifescore.ToString ();

		PlayerScore.instance.setLife(lifescore);
	}

	public void pauseTheGame ()
	{
		Time.timeScale = 0f;
		pausepanel.SetActive (true);
	}

	public void resumeGame ()
	{
		Time.timeScale = 1f;
		pausepanel.SetActive (false);
	}

	public void quitGame ()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene ("MainMenu", LoadSceneMode.Single);
	}

	public void startTheGame ()
	{
		Time.timeScale = 1f;
		readyButton.SetActive (false);
	}
}