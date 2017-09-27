﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

	public float Force;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetKey( KeyCode.UpArrow ) )
		{
			transform.position = transform.position + Vector3.up * Time.deltaTime * Force;
		}

		if( Input.GetKey( KeyCode.DownArrow ) )
		{
			transform.position = transform.position + Vector3.down * Time.deltaTime * Force;
		}

		if( Input.GetKey( KeyCode.RightArrow ) )
		{
			transform.position = transform.position + Vector3.right * Time.deltaTime * Force;
		}

		if( Input.GetKey( KeyCode.LeftArrow ) )
		{
			transform.position = transform.position + Vector3.left * Time.deltaTime * Force;
		}
	}
}