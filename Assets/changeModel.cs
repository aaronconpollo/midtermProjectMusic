using UnityEngine;
using System.Collections;

public class changeModel : MonoBehaviour {

	public GameObject original;
	public GameObject metro;
	public GameObject dollar;

	// Use this for initialization
	void Start () {

		original.SetActive (true);
		metro.SetActive (false);
		dollar.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown (KeyCode.M) ) {

			original.SetActive (false);
			metro.SetActive (true);
			dollar.SetActive (false);

		} else if (Input.GetKeyDown ( KeyCode.E )) {
			original.SetActive (false);
			metro.SetActive (false);
			dollar.SetActive (true);
		} else if (Input.GetKeyDown (KeyCode.O) ) {

			original.SetActive (true);
			metro.SetActive (false);
			dollar.SetActive (false);

		}


	
	}
}
