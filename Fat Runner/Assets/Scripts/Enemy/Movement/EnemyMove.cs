﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

	// Variables para uso externo
	public int Step;
	public bool IsFlying;
	public float Leftstep = 0;
	public float VerticalStep = 0;

	// Variables para uso del script
	private bool isMovingLeft;

    // Use this for initialization
    void Start () {
		
		isMovingLeft = true;

	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if( IsFlying )
		{
			transform.Translate( Vector2.up * Mathf.Sin(Time.timeSinceLevelLoad) * VerticalStep * Time.deltaTime );
			transform.Translate( Vector2.left * Leftstep * Time.deltaTime );
		}
		else
		{
			if( isMovingLeft )
		{
			transform.Translate( Vector2.left * Step * Time.deltaTime );
		}
		else
		{
			transform.Translate( Vector2.right * Step * Time.deltaTime );
		}
		}
        

	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if( !other.transform.tag.Equals("Player") && other.transform.tag.Equals("Wall") )
		{
			isMovingLeft = !isMovingLeft;
		}
	}

	public void SetMovingLeft(bool Change)
	{
		isMovingLeft = Change;
	}

	public void SetSpeedofChase()
	{
		Step = Step * 2;
	}

	public void SetSpeedOfPatrol()
	{
		Step = Step / 2;
	}

}