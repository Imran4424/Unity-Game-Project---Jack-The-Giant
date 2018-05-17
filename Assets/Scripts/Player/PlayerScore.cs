using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour {

	[SerializeField]
	private AudioClip coinClip,lifeClip;

	private CameraScript cameraScript;

	private Vector3 peviousPosition;
	private bool countScore;

	public static int scoreCount;
	public static int lifeScoreCount;
	public static int coinScoreCount;
	
		
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
