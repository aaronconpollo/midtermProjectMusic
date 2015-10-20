using UnityEngine;
using System.Collections;

public class triggerModel : MonoBehaviour {

	public GameObject original;
	public GameObject metro;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame


		void OnTriggerExit (Collider activator) { // parameter will get automatically filled-in with the activator
			if( activator.tag == "Player" ) {
				original.SetActive (true);
				metro.SetActive (false);
			}
			
		}
	}

