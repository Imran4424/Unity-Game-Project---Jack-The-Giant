﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableScript : MonoBehaviour {

	void OnEnable()
	{
		Invoke("destroyCollectables",6f);
	}

	void destroyCollectables()
	{
		gameObject.SetActive(false);
	}
}
