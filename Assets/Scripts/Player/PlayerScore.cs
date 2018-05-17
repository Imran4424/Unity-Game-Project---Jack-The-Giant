using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour {

	[SerializeField]
	private AudioClip coinClip,lifeClip;

	private CameraScript cameraScript;

	private Vector3 previousPosition;
	private bool countScore;

	public static int scoreCount;
	public static int lifeScoreCount;
	public static int coinScoreCount;

	void Awake()
	{
		cameraScript = Camera.main.GetComponent<CameraScript>();
	}	
	// Use this for initialization
	void Start () 
	{
		previousPosition = transform.position;
		countScore = true;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
