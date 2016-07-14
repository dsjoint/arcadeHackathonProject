﻿using UnityEngine;
using System.Collections;

public class PlankScript : MonoBehaviour {

	public Sprite updated;

	private BoardManager boardScript;
	private SpriteRenderer spriteScript;

	private bool active = true;

	void Awake(){
		boardScript = GameObject.Find ("BoardManager").GetComponent<BoardManager> ();
		spriteScript = GetComponent<SpriteRenderer> ();

	}

	void OnMouseDown(){

		if (active == false) {
			return;
		}

		if (boardScript.playerTurn == true && boardScript.gameContinue == true) {

			active = false;
			spriteScript.sprite = updated;

			GameObject[] closeNodes = new GameObject[2];
			closeNodes = boardScript.closestNode (gameObject);

			int index1 = boardScript.objectToIndex [closeNodes [0]];
			int index2 = boardScript.objectToIndex [closeNodes [1]];

			boardScript.graph.adjList [index1].Remove (index2);
			boardScript.graph.adjList [index2].Remove (index1);

			//boardScript.graph.printGraph ();

			boardScript.playerTurn = false;
			boardScript.studentTurn = true;
		}
	}

}
