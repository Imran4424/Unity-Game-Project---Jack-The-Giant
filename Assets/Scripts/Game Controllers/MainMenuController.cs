﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{

	}

	public void StartGame ()
	{
		SceneManager.LoadScene ("GamePlay", LoadSceneMode.Single);
	}

	public void HighScoreMenu()
	{
		SceneManager.LoadScene("HighScore", LoadSceneMode.Single);
	}

	public void AboutMenu()
	{
		SceneManager.LoadScene();
	}

}