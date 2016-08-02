using UnityEngine;
using System.Collections;
using System;

public class currentTime : MonoBehaviour {

	// Use this for initialization

	public DateTime time;

	void Start () {

		time = System.DateTime.Now;
	}
	
	// Update is called once per frame
	void Update () {
		time = System.DateTime.Now;
	
	}
}
