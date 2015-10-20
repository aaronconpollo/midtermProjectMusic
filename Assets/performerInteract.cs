using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class performerInteract : MonoBehaviour {
	
	public Transform player, performer, performer2, performer3, performer4;
	public  AudioSource correctSound, wrongSound1, wrongSound2, wrongSound3;
	public Text textUI;
	public Text textUI2;
	public static bool isFinished;
	
	
	
	
	// Use this for initialization
	void Start () {
		textUI.text = "";
		textUI2.text = "";
	}
	
	// Update is called once per frame
	void Update () {

		if( Vector3.Distance (player.position, performer.position) < 4f){
			textUI.text = "Could you spare a dollar? Just a musician trying to make it.";
			textUI2.text = "To give a dollar, press M";
		} else if ( Vector3.Distance (player.position, performer2.position) < 4f){
			textUI.text = "Could you spare a dollar? Just a musician trying to make it.";
			textUI2.text = "To give a dollar, press M";
		} else if ( Vector3.Distance (player.position, performer3.position) < 4f){
			textUI.text = "Could you spare a dollar? Just a musician trying to make it.";
			textUI2.text = "To give a dollar, press M";
		} else if ( Vector3.Distance (player.position, performer4.position) < 4f){
			textUI.text = "Could you spare a dollar? Just a musician trying to make it.";
			textUI2.text = "To give a dollar, press M";
		} else {
			textUI.text = "";
			textUI2.text = "";
		}

		
		/*if( (Vector3.Distance (player.position, performer.position) < 4f) && (Input.GetKeyDown (KeyCode.M)) )  {
			wrongSound1.Stop();
			wrongSound2.Stop();
			wrongSound3.Stop();
			correctSound.Play();
		}
		*/

		if( (Vector3.Distance (player.position, performer.position) < 4f) && (Input.GetKeyDown (KeyCode.M)) && performer.name == "drums")
		{
			Application.LoadLevel("drumEndScene");
		} else if( (Vector3.Distance (player.position, performer.position) < 4f) && (Input.GetKeyDown (KeyCode.M)) && performer.name == "endDrums")
		{
			Application.LoadLevel("endDrumsEndScene");
		} else if( (Vector3.Distance (player.position, performer.position) < 4f) && (Input.GetKeyDown (KeyCode.M)) && performer.name == "chip")
		{
			Application.LoadLevel("chipEndScene");
		} else if( (Vector3.Distance (player.position, performer.position) < 4f) && (Input.GetKeyDown (KeyCode.M)) && performer.name == "guitar")
		{
			Application.LoadLevel("guitarEndScene");
		}
		
	}
	
}
