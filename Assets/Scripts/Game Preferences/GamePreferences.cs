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

	public static int GetMusicState ()
	{
		return PlayerPrefs.GetInt (GamePreferences.IsMusicOn);
	}

	public static void SetMusicState (int state)
	{
		PlayerPrefs.SetInt (GamePreferences.IsMusicOn, state);
	}

	public static int GetEasyDifficultyState ()
	{
		return PlayerPrefs.GetInt (GamePreferences.EasyDifficulty);
	}

	public static void SetEasyDifficultyState (int state)
	{
		PlayerPrefs.SetInt (GamePreferences.EasyDifficulty, state);
	}

	public static int GetMediumDifficultyState ()
	{
		return PlayerPrefs.GetInt (GamePreferences.MediumDifficulty);
	}

	public static void SetMediumDifficultyState (int state)
	{
		PlayerPrefs.SetInt (GamePreferences.MediumDifficulty, state);
	}

	public static int GetHardDifficultyState ()
	{
		return PlayerPrefs.GetInt (GamePreferences.HardDifficulty);
	}

	public static void SetHardDifficultyState (int state)
	{
		PlayerPrefs.SetInt (GamePreferences.HardDifficulty, state);
	}

	public static int GetEasyDifficultyHighScore ()
	{
		return PlayerPrefs.GetInt (GamePreferences.EasyDifficultyHighScore);
	}

	public static void SetEasyDifficultyHighScore (int score)
	{
		PlayerPrefs.SetInt (GamePreferences.EasyDifficultyHighScore, score);
	}

	public static int GetMediumDifficultyHighScore ()
	{
		return PlayerPrefs.GetInt (GamePreferences.MediumDifficultyHighScore);
	}

	public static void SetMediumDifficultyHighScore (int score)
	{
		PlayerPrefs.SetInt (GamePreferences.MediumDifficultyHighScore, score);
	}

	public static int GetHardDifficultyHighScore ()
	{
		return PlayerPrefs.GetInt (GamePreferences.HardDifficultyHighScore);
	}

	public static void SetHardDifficultyHighScore (int score)
	{
		PlayerPrefs.SetInt (GamePreferences.HardDifficultyHighScore, score);
	}

}