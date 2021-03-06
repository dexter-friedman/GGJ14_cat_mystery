﻿using UnityEngine;
using System.Collections;

public class BallBehavior : MonoBehaviour {
	private Vector3 pawDirection;

	private bool triggerflag = false;
	public GameManager gm;

	public float bounceForce = 100;

	// Use this for initialization
	void Start () {
		//gameObject.renderer.material.color = Color.black;
		Debug.Log ("Start of level, triggerleft: " + gm.triggersLeft);
	}
	
	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate(){
		rigidbody.AddForce (Vector3.down * 10);               
	}


	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Wall")
		{
			rigidbody.AddForce(bounceForce * collision.gameObject.transform.forward.x, 
			                   bounceForce * collision.gameObject.transform.forward.y, 
			                   bounceForce * collision.gameObject.transform.forward.z );
		}

		if (collision.gameObject.name == "Collision Cube" )
		{
			if (triggerflag == false ){
				gm.triggersLeft--;
				triggerflag = true;
				gameObject.renderer.material.color = Color.red;
			}
			Debug.Log ( "triggersLeft" + gm.triggersLeft );
		}

		/*
		if(collision.gameObject.name == "Paw")
		{
			rigidbody.AddForce (collision.gameObject.rigidbody.velocity * 200);
			/*
			pawDirection = collision.gameObject.;
			rigidbody.AddRelativeForce(pawDirection * 200);


		}
		*/
	}
	


}

