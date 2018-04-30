using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

public class Player : MonoBehaviour {

	public float speed = 8f , maxVelocity = 4f; 

	private Rigidbody2D myBody;
	private Animator anim;

	// this method will run first
	void Awake()
	{
		myBody = GetComponent <Rigidbody2D> ();
		anim = GetComponent	<Animator> ();
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}


}