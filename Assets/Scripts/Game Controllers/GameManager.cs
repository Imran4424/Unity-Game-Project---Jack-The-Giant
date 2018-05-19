using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

	public static GameManager instance;

	[HideInInspector]
	public bool gameStartedFormMainMenu, gameStartedAfterPlayerDied;

	[HideInInspector]
	public int score = 0, coinScore = 0, lifeScore = 0;

	void Awake ()
	{
		MakeSingleton ();
	}

	void OnEnable ()
	{
		SceneManager.sceneLoaded += LevelFinishedLoading;
	}

	void OnDisable ()
	{
		SceneManager.sceneLoaded -= LevelFinishedLoading;
	}

	void LevelFinishedLoading (Scene sceneName, LoadSceneMode mode)
	{
		if (sceneName.name == "GamePlay")
		{
			if (!GameManager.instance.gameStartedAfterPlayerDied)
			{
				score = 0;
				coinScore = 0;
				lifeScore = 2;

				GamePlayController.instance.setScore (score);
				GamePlayController.instance.setCoinScore (coinScore);
				GamePlayController.instance.setLifeScore (lifeScore);
			}
			else
			{
				score = GameManager.instance.score;
				coinScore = GameManager.instance.coinScore;
				lifeScore = GameManager.instance.lifeScore;

				GamePlayController.instance.setScore (score);
				GamePlayController.instance.setCoinScore (coinScore);
				GamePlayController.instance.setLifeScore (lifeScore);

			}
		}
	}

	/*
	 * It's singleton pattern in C# scripts
	 */
	void MakeSingleton ()
	{
		if (instance != null)
		{
			Destroy (gameObject);
		}
		else
		{
			instance = this;
			DontDestroyOnLoad (gameObject);
		}
	}


	public void CheckGameStatus(int score, int coinScore, int lifeScore)
	{
		if (lifeScore < 0)
		{
			gameStartedFormMainMenu = false;
			gameStartedAfterPlayerDied = false;

			GamePlayController.instance.gameOvershowPanel(score,coinScore);
		}
		else
		{
			this.score = score;
			this.coinScore = coinScore;
			this.lifeScore = lifeScore;

			GamePlayController.instance.setScore(score);

			gameStartedFormMainMenu = false;
			gameStartedAfterPlayerDied = true;			
		}

	}
}