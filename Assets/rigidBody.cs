using UnityEngine;
using System.Collections;

public class rigidBody : MonoBehaviour {
	
	Rigidbody rbody;
	public float moveSpeed = 5f;
	Vector3 inputVector; //remembers which direction i want to  go in based on input
	
	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame input/graphics
	void Update () {

		float jump = Input.GetButtonDown ("Jump") ? .5f: 0f;
		inputVector = new Vector3 (Input.GetAxis ("Horizontal"), jump, Input.GetAxis ("Vertical" ));
		Debug.Log ( "input: " + inputVector );
		float mouseX = Input.GetAxis ("Mouse X");
		float mouseY = Input.GetAxis ("Mouse Y");
		transform.Rotate (0f, mouseX, 0f);
		
		
	}
	//physics
	void FixedUpdate() {
		float yVelocity = rbody.velocity.y;
		rbody.velocity = transform.TransformDirection (inputVector) * moveSpeed;
		rbody.velocity += new Vector3 (0f, yVelocity, 0f);
		Debug.Log ("velocity: " + rbody.velocity);
	}
}
