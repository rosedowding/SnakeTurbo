using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;

public class background : MonoBehaviour {
    Vector3 StartPOS;

	// Use this for initialization
	void Start () {
        StartPOS = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate((new Vector3(-1, 0, 0)) * Player.Player.speed * Time.deltaTime);
	}
}
