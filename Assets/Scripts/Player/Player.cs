﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

	public float speed = 8f, maxVelocity = 4f;

	private Rigidbody2D myBody;
	private Animator anim;

	// this method will run first when the game run
	void Awake ()
	{
		myBody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{

	}

	/*
	 *	A different version of update function FixedUpdate
	 *	FixedUpdate is useful to physics related calculation
	 */

	void FixedUpdate ()
	{
		PlayerMoveKeyboard ();
	}

	void PlayerMoveKeyboard ()
	{
		float forceX = 0f;
		float velocity = Mathf.Abs (myBody.velocity.x);

		float h = Input.GetAxisRaw ("Horizontal");

		if (h > 0)
		{
			if (velocity < maxVelocity)
			{
				forceX = speed;

				Vector3 temp = transform.localScale;
				temp.x = 1.3f;
				transform.localScale = temp;

				anim.SetBool ("walk", true);
			}
		}
		else if (h < 0)
		{
			if (velocity < maxVelocity)
			{
				forceX = -speed;

				Vector3 temp = transform.localScale;
				temp.x = -1.3f;
				transform.localScale = temp;

				anim.SetBool ("walk", true);
			}
		}
		else
		{
			anim.SetBool ("walk", false);
		}

		myBody.AddForce (new Vector2 (forceX, 0));
	}
}