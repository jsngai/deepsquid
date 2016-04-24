﻿using UnityEngine;
using System.Collections;

public class modelSwitch : MonoBehaviour {

	public GameObject other;
	public bool isFirst = false;

	// Use this for initialization
	void Start () {
		if (!isFirst) {
			gameObject.SetActive (false);
		} else {
			other.SetActive (false);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision o){
		if (o.gameObject.GetComponent<Pickupable> () && other) {
			print ("here in collision");
			if (o.gameObject.GetComponent<Pickupable> ().isThrown ()) {
				print ("here in is Thrown");
				o.gameObject.GetComponent<Pickupable> ().changeThrown ();
				changeModels ();

			}

		}
	}


	private void changeModels(){
		other.SetActive (true);
		gameObject.SetActive (false);
	}
}
