﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapIsGround : MonoBehaviour {

    [SerializeField]
    private PlayerMoveKeyBoard player;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMoveKeyBoard>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            player.isGrounded = false;
        }
    }
}
