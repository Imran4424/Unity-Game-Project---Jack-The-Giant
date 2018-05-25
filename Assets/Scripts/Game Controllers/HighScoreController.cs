using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HighScoreController : MonoBehaviour {

	[SerializeField]
	private Text scoreText, coinText;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	void SetScore(int score, int coins)
	{
		scoreText.text = score.ToString();
		coinText.text = coins.ToString();
	}

	void SetScoreBasedOnDifficulty()
	{
		
	}
	
	public void BackButton()
	{
		SceneManager.LoadScene("MainMenu",LoadSceneMode.Single);
	}

}
