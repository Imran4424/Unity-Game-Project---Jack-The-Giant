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
			
		}
	}
	
	
	// Update is called once per frame
	void Update () {
		
	}
}
