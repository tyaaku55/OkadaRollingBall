﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour {

	// Use this for initialization

	public float speed = 10;

	private void FixedUpdate () 
	{
		float x = Input.GetAxis ("Horizontal");
		float z = Input.GetAxis ("Vertical");

		Rigidbody rigidbody = GetComponent<Rigidbody> ();

		rigidbody.AddForce (x * speed, 0, z * speed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
