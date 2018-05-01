using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScript : MonoBehaviour {

	
	void Start () 
	{
		SpriteRenderer sr = GetComponent <SpriteRenderer> ();
		Vector3 tempScale = transform.localScale;

		float width = sr.sprite.bounds.size.x;

		float worldHeight = Camera.main.orthographicSize 
	}
	
}
