﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundCollector : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D target)
	{
		if (target.tag == "Background")
		{
			
		}
	}
}
