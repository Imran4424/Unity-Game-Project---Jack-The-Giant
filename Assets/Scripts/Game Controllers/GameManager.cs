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
	public int score, coinScore, lifeScore;

	void Awake ()
	{
		MakeSingleton ();
	}

	void Start()
	{
		InitializeVariables();
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

	void InitializeVariables ()
	{
		if (!PlayerPrefs.HasKey ("Game Initialized"))
		{
			GamePreferences.SetEasyDifficultyState (1);
			GamePreferences.SetEasyDifficultyHighScore (0);
			GamePreferences.SetEasyDifficultyCoinScore (0);

			GamePreferences.SetMediumDifficultyState (0);
			GamePreferences.SetMediumDifficultyHighScore (0);
			GamePreferences.SetMediumDifficultyCoinScore (0);

			GamePreferences.SetHardDifficultyState (0);
			GamePreferences.SetHardDifficultyHighScore (0);
			GamePreferences.SetHardDifficultyCoinScore (0);

			PlayerPrefs.SetInt("Game Initialized",777);
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

	public void CheckGameStatus (int score, int coinScore, int lifeScore)
	{
		//Debug.Log("lifeScore = " + lifeScore);

		if (lifeScore < 0)
		{
			if(GamePreferences.GetEasyDifficultyState() == 1)
			{
				int highScore = GamePreferences.GetEasyDifficultyHighScore();
				int coinHighScore = GamePreferences.GetEasyDifficultyCoinScore();

				if (highScore < score)
				{
					GamePreferences.SetEasyDifficultyHighScore(score);
				}

				if (coinHighScore < coinScore)
				{
					GamePreferences.SetEasyDifficultyCoinScore(coinScore);
				}
			}

			if (GamePreferences.GetMediumDifficultyState() == 1)
			{
				int highScore = GamePreferences.GetMediumDifficultyHighScore();
				int coinHighScore = GamePreferences.GetMediumDifficultyCoinScore();

				if (highScore < score)
				{
					GamePreferences.SetMediumDifficultyHighScore(score);
				}

				if (coinHighScore < coinScore)
				{
					GamePreferences.SetMediumDifficultyCoinScore(coinScore);
				}
			}

			if (GamePreferences.GetHardDifficultyState() == 1)
			{
				int highScore = GamePreferences.GetHardDifficultyHighScore();
				int coinHighScore = GamePreferences.GetHardDifficultyCoinScore();

				if (highScore < score)
				{
					GamePreferences.SetHardDifficultyHighScore(score);
				}

				
			}

			gameStartedFormMainMenu = false;
			gameStartedAfterPlayerDied = false;

			GamePlayController.instance.gameOvershowPanel (score, coinScore);
		}
		else
		{
			this.score = score;
			this.coinScore = coinScore;
			this.lifeScore = lifeScore;

			/* GamePlayController.instance.setScore(score);
			GamePlayController.instance.setCoinScore(coinScore);
			GamePlayController.instance.setLifeScore(lifeScore); */

			gameStartedFormMainMenu = false;
			gameStartedAfterPlayerDied = true;

			GamePlayController.instance.RestartTheGame ();
		}

	}
}