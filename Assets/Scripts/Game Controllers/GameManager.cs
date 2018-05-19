using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	[HideInInspector]
	public bool gameStartedFormMenu, gameStartedAfterPlayerDied;

	[HideInInspector]
	public int score, coinScore, lifeScore;

	void Awake()
	{
		MakeSingleton();
	}



	/*
	* It's singleton pattern in C# scripts
	*/
	void MakeSingleton()
	{
		if (instance != null)
		{
			Destroy(gameObject);
		}
		else
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}
	}

}
