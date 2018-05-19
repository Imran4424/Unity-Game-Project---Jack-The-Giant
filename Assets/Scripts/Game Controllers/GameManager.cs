﻿using System.Collections;
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

	void LevelFinishedLoading ()
	{

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