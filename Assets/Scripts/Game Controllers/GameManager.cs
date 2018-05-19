using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

	public static GameManager instance;

	[HideInInspector]
	public bool gameStartedFormMenu, gameStartedAfterPlayerDied;

	[HideInInspector]
	public int score, coinScore, lifeScore;

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
		if(sceneName.name == "GamePlay")
		{
			if (!GameManager.instance.gameStartedAfterPlayerDied)
			{
				score = 0;
				lifeScore = 2;
			}
			else
			{
				
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

}