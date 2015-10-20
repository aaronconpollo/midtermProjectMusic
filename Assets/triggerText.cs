using UnityEngine;
using System.Collections;
using UnityEngine.UI;





public class triggerText : MonoBehaviour {

	public Text textUI;

	
	// Use this for initialization
	void Start () {
		textUI.text = "";

		
	}
	
	// whatever code is here: will get fired when something enters the trigger
	// OR, if you put this on the player, it will fire when the player enters a trigger
	/*void OnTriggerEnter (Collider activator) { // parameter will get automatically filled-in with the activator
		if( activator.tag == "Player" ) {
			Debug.Log ("text is:");

		}
		textUI.text = "To get our your Metrocard, press M";
	}
	*/

	void OnTriggerStay (Collider activator) { 
		// parameter will get automatically filled-in with the activator
		if( activator.tag == "Player" ) {
			textUI.text = "To get out your Metrocard, press C";
		}
	}

	void OnTriggerExit (Collider activator) { // parameter will get automatically filled-in with the activator
		if( activator.tag == "Player" ) {
			textUI.text = "";
		}

	}
}