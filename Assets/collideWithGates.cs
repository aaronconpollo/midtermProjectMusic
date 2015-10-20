using UnityEngine;
using System.Collections;

public class collideWithGates : MonoBehaviour {
	public GameObject turnstile;
	public GameObject turnstileModel;



	/*Collider turnstile = 

	void onTriggerEnter (Collider activator) {

		if(activator.tag == "Player" ) {

		} else if ( activator.tag == "Passable" ) {
			Destroy (activator.gameObject);
		}
			
}
*/
	void Start() {
		turnstileModel.GetComponent<Renderer>().material.color = Color.red;
	}

	void Update() {
		if (Input.GetKeyDown(KeyCode.C)) {
			//turnstileCollider.isTrigger = true;
			turnstile.GetComponent<BoxCollider>().enabled = false;
			//turnstileModel.GetComponent<Material>().color = Color.green;
			turnstileModel.GetComponent<Renderer>().material.color = Color.green;
		}

	}
}
