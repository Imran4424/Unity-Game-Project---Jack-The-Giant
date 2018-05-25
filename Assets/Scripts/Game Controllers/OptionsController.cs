using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsController : MonoBehaviour {

	[SerializeField]
	private GameObject easySign, mediumSign, HardSign;

	// Use this for initialization
	void Start () {
		
	}

	void SetInitialDifficulty()
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void BackButton()
	{
		SceneManager.LoadScene("MainMenu",LoadSceneMode.Single);
	}
}
