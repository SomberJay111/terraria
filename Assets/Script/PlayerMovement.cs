﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

Rigidbody2D rigid ;
public float Timer;
	// Use this for initialization
	void Start () {
		rigid = gameObject.GetComponent<Rigidbody2D>();
        Timer = 0;
	}
	public bool onGround = true;
	// Update is called once per frame
	void Update () {
        Timer += Time.deltaTime;
		if (Input.GetKeyDown("w") && onGround == true){

			rigid. AddRelativeForce(new Vector2(0,10), ForceMode2D.Impulse);
			onGround = false;
		} 
		if (Input.GetKey("d")){
            rigid.AddRelativeForce(new Vector2(10, 0), ForceMode2D.Force);
		}
        if (Input.GetKey("a"))
        {
            rigid.AddRelativeForce(new Vector2(-10, 0), ForceMode2D.Force);
        }
        if (Input.GetKey("s"))
        {
			Timer = 0;
			GetComponent<Collider2D>().enabled = false;
        }
		if (Input.GetMouseButtonDown (0)){
			transform.GetChild (0).GetComponent <Collider2D>().;
		}
		RaycastHit hitInfo;
        //hitInfo.transform.gameObject.GetComponent<tree>().IAMMElted();
		if (Timer > 0.5){
            GetComponent<Collider2D>().enabled = true;
		}
        // GetComponent<Collider2D>().enabled=! Input.GetKey("s"); // true when press down

        //  want to turn off when down

	
		
	} 

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.CompareTag ("terrain")) {
				onGround = true;
			}

	}
}
