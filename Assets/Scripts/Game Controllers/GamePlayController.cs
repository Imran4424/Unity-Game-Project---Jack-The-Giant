﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayController : MonoBehaviour {

	public static GamePlayController instance;

	[SerializeField]
	private Text scoretext,cointext,lifetext;

	[SerializeField]
	private GameObject pausepanel;

	void Awake()
	{
		makeInstance();
	}

	void makeInstance()
	{
		if (instance == null)
		{
			instance = this;
		}
	}


	public void pauseTheGame()
	{
		Time.timeScale = 0f;
		pausepanel.SetActive(true);
	}

	public void resumeGame()
	{
		Time.timeScale = 1f;
		pausepanel.SetActive(false);
	}

	public void quitGame()
	{
		
	}
}
