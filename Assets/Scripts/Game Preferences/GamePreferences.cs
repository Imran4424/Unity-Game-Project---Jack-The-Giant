using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GamePreferences
{

	public static string EasyDifficulty = "EasyDifficulty";
	public static string MediumDifficulty = "MediumDifficulty";
	public static string HardDifficulty = "HardDifficulty";

	public static string EasyDifficultyHighScore = "EasyDifficultyHighScore";
	public static string MediumDifficultyHighScore = "MediumDifficultyHighScore";
	public static string HardDifficultyHighScore = "HardDifficultyHighScore";

	public static string EasyDifficultyCoinScore = "EasyDifficultyCoinScore";
	public static string MediumDifficultyCoinScore = "MediumDifficultyCoinScore";
	public static string HardDifficultyCoinScore = "HardDifficultyCoinScore";

	public static string IsMusicOn = "IsMusicOn";

	/*
	We are going to use intergers to represent boolean variables
	0 - false, 1 - true
	*/

	/*
	Setting and Getting Music states
	*/

	public static int GetMusicState ()
	{
		return PlayerPrefs.GetInt (GamePreferences.IsMusicOn);
	}

	public static void SetMusicState (int state)
	{
		PlayerPrefs.SetInt (GamePreferences.IsMusicOn, state);
	}

	/*
	setting and getting - State
	Easy
	Medium
	Difficult
	*/

	//Easy
	public static int GetEasyDifficultyState ()
	{
		return PlayerPrefs.GetInt (GamePreferences.EasyDifficulty);
	}

	public static void SetEasyDifficultyState (int state)
	{
		PlayerPrefs.SetInt (GamePreferences.EasyDifficulty, state);
	}

	//Medium
	public static int GetMediumDifficultyState ()
	{
		return PlayerPrefs.GetInt (GamePreferences.MediumDifficulty);
	}

	public static void SetMediumDifficultyState (int state)
	{
		PlayerPrefs.SetInt (GamePreferences.MediumDifficulty, state);
	}

	//Hard
	public static int GetHardDifficultyState ()
	{
		return PlayerPrefs.GetInt (GamePreferences.HardDifficulty);
	}

	public static void SetHardDifficultyState (int state)
	{
		PlayerPrefs.SetInt (GamePreferences.HardDifficulty, state);
	}

	/*
	setting and getting - HighScore
	Easy
	Medium
	Difficult
	*/

	//Easy
	public static int GetEasyDifficultyHighScore ()
	{
		return PlayerPrefs.GetInt (GamePreferences.EasyDifficultyHighScore);
	}

	public static void SetEasyDifficultyHighScore (int score)
	{
		PlayerPrefs.SetInt (GamePreferences.EasyDifficultyHighScore, score);
	}

	//Medium
	public static int GetMediumDifficultyHighScore ()
	{
		return PlayerPrefs.GetInt (GamePreferences.MediumDifficultyHighScore);
	}

	public static void SetMediumDifficultyHighScore (int score)
	{
		PlayerPrefs.SetInt (GamePreferences.MediumDifficultyHighScore, score);
	}

	//Hard
	public static int GetHardDifficultyHighScore ()
	{
		return PlayerPrefs.GetInt (GamePreferences.HardDifficultyHighScore);
	}

	public static void SetHardDifficultyHighScore (int score)
	{
		PlayerPrefs.SetInt (GamePreferences.HardDifficultyHighScore, score);
	}

	public static int GetEasyDifficultyCoinScore ()
	{
		return PlayerPrefs.GetInt (GamePreferences.EasyDifficultyCoinScore);
	}

	public static void SetEasyDifficultyCoinScore (int coins)
	{
		PlayerPrefs.SetInt (GamePreferences.EasyDifficultyCoinScore, coins);
	}

	public static int GetMediumDifficultyCoinScore ()
	{
		return PlayerPrefs.GetInt (GamePreferences.MediumDifficultyCoinScore);
	}

	public static void SetMediumDifficultyCoinScore (int coins)
	{
		PlayerPrefs.SetInt (GamePreferences.MediumDifficultyCoinScore, coins);
	}

	public static int GetHardDifficultyCoinScore ()
	{
		return PlayerPrefs.GetInt (GamePreferences.HardDifficultyCoinScore);
	}

	public static void SetHardDifficultyCoinScore (int coins)
	{
		PlayerPrefs.SetInt (GamePreferences.HardDifficultyCoinScore, coins);
	}

}