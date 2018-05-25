using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsController : MonoBehaviour
{

	[SerializeField]
	private GameObject easySign, mediumSign, HardSign;

	// Use this for initialization
	void Start ()
	{

	}

	void SetInitialDifficulty (string difficulty)
	{
		switch (difficulty)
		{
			case "easy":
				easySign.SetActive (true);
				mediumSign.SetActive (false);
				HardSign.SetActive (false);
				break;

			case "medium":
				easySign.SetActive (false);
				mediumSign.SetActive (true);
				HardSign.SetActive (false);
				break;

			case "hard":
				easySign.SetActive (false);
				mediumSign.SetActive (false);
				HardSign.SetActive (true);
				break;

		}
	}

	void SetDifficulty ()
	{
		if (GamePreferences.GetEasyDifficultyState () == 1)
		{
			SetInitialDifficulty ("easy");
		}

		if (GamePreferences.GetMediumDifficultyState () == 1)
		{
			SetInitialDifficulty ("medium");
		}

		if (GamePreferences.GetHardDifficultyState () == 1)
		{
			SetInitialDifficulty ("hard");
		}

	}

	// Update is called once per frame
	void Update ()
	{

	}

	public void BackButton ()
	{
		SceneManager.LoadScene ("MainMenu", LoadSceneMode.Single);
	}
}