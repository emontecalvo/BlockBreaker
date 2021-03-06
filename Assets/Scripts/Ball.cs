﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public Paddle paddle;

	private Rigidbody2D myRigidBody2D;

	private bool hasStarted = false;

	private Vector3 paddleToBallVector;

	// Use this for initialization
	void Start () {
		paddleToBallVector = this.transform.position - paddle.transform.position;
		myRigidBody2D = GetComponent<Rigidbody2D> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!hasStarted) {
			this.transform.position = paddle.transform.position + paddleToBallVector;

			if (Input.GetMouseButton (0)) {
				hasStarted = true;

				myRigidBody2D.velocity = new Vector2 (2f, 10f);

//				this.rigidbody2D.velocity = new Vector2 (2f, 10f);    OLD DEPRICATED CODE
				// use myRigidBody2D / see above
			}
		}

	}
}
