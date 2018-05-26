using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
	[SerializeField]
	private Button musicBtns;

	[SerializeField]
	private Sprite[] musicIcons;

	// Use this for initialization
	void Start ()
	{
		CheckToPlayTheMusic ();
	}

	/*
	This function will help the music option stable like

	when we turn off or on the music then left/close  game

	after that, when we will reopen the game next time

	we will find the past setting saved that we save last time play the game 
	*/

	void CheckToPlayTheMusic ()
	{
		if (GamePreferences.GetMusicState () == 1)
		{
			MusicController.instance.PlayMusic (true);
			musicBtns.image.sprite = musicIcons[1];
		}
		else
		{
			MusicController.instance.PlayMusic (false);
			musicBtns.image.sprite = musicIcons[0];

		}
	}

	public void StartGame ()
	{
		GameManager.instance.gameStartedFormMainMenu = true;

		SceneManager.LoadScene ("GamePlay", LoadSceneMode.Single);
	}

	public void HighScoreMenu ()
	{
		SceneManager.LoadScene ("HighScore", LoadSceneMode.Single);
	}

	public void AboutMenu ()
	{
		SceneManager.LoadScene ("About", LoadSceneMode.Single);
	}

	public void OptionsMenu ()
	{
		SceneManager.LoadScene ("Options", LoadSceneMode.Single);
	}

	public void QuitMenu ()
	{
		Application.Quit ();
	}

	public void MusicButton ()
	{
		if (GamePreferences.GetMusicState () == 0)
		{
			GamePreferences.SetMusicState (1);
			MusicController.instance.PlayMusic (true);
			musicBtns.image.sprite = musicIcons[1];
		}
		else if (GamePreferences.GetMusicState () == 1)
		{
			GamePreferences.SetMusicState (0);
			MusicController.instance.PlayMusic (false);
			musicBtns.image.sprite = musicIcons[0];
		}
	}

}