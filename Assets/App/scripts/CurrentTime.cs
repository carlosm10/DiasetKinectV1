using UnityEngine;
using System.Collections;
using System;

public class CurrentTime : MonoBehaviour {

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
