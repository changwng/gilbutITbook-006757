﻿using UnityEngine;
using System.Collections;

public class cubeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void bigsize(){
	
		this.transform.localScale = new Vector3 (3.0f, 3.0f, 3.0f);
	}

}
