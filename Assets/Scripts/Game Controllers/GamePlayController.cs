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
}
