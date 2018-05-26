using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour {

	public static MusicController instance;

	private AudioSource audioSource;

	void Awake()
	{
		
	}

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
	
	
	// Update is called once per frame
	void Update () {
		
	}
}
