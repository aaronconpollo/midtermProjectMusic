using UnityEngine;
using System.Collections;

public class startGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		// if player presses Space
		if (Input.GetMouseButtonDown (0))
		{
			// then change to the actual "game" scene
			// change "prototype01" to the name of the scene that you want to change it to
			Application.LoadLevel("midterm");
		}

	
	}
}
