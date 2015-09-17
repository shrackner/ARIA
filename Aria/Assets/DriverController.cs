﻿using UnityEngine;
using System.Collections;

public class DriverController : MonoBehaviour {

	public GameObject parent;
	public GameObject driverPos;
	public GameObject driver;
	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = driver.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		updatePos();

		// start driver up anim
		if((65 > parent.transform.eulerAngles.z || parent.transform.eulerAngles.z >= 295) && anim.GetInteger("dir") != 1) {
			anim.SetInteger("dir", 1);
		}
		// start Turn driver right anim
		else if(225 <= parent.transform.eulerAngles.z && parent.transform.eulerAngles.z < 295 && anim.GetInteger("dir") != 2) {
			anim.SetInteger("dir", 2);
		}
		// down anim
		else if(135 <= parent.transform.eulerAngles.z && parent.transform.eulerAngles.z < 225 && anim.GetInteger("dir") != 3) {
			anim.SetInteger("dir", 3);
		}
		// left anim
		else if(65 <= parent.transform.eulerAngles.z && parent.transform.eulerAngles.z < 135 && anim.GetInteger("dir") != 4) {
			anim.SetInteger("dir", 4);
		}
	}

	void updatePos() {
		transform.position = new Vector2(driverPos.transform.position.x, driverPos.transform.position.y);
	}
}
