﻿using UnityEngine;
using System.Collections;

public class PlankScript : MonoBehaviour {

	void OnMouseDown(){
		gameObject.SetActive (false);
	}
		
	void Update(){
		Debug.Log(gameObject.transform)
	}

}
