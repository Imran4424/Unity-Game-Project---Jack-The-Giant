﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudCollector : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D target)
	{
		if(target.tag == "Cloud" || target.tag == "Deadly")
		{
			target.gameObject.SetActive(false);
		}
	}

	void run()
	{
		float forceX = 0f;

		float velocity = 1f;

		float h = Input.Get
	}
}
