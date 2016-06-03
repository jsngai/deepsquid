﻿using UnityEngine;
using System.Collections;

public class eyesightOverride : MonoBehaviour {
	public static float radiusSize = 50f;
	public static float eyeSightDegrees = 360f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.Find ("eyesight collider").gameObject.GetComponent<SphereCollider> ().radius < radiusSize)
			transform.Find ("eyesight collider").gameObject.GetComponent<SphereCollider> ().radius = radiusSize;
		GetComponent<EnemySight> ().fieldOfViewAngle = eyeSightDegrees;
	}
}
