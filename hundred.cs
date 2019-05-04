using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hundred : MonoBehaviour {
	public GameObject result;//public GameObject result; //dhlwnoume to object result pou excei to script variables
	public variables script;//orizoume to script na einai tupou variable

	void Start () {
		script = result.GetComponent<variables> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter() {
		script.hundred = true;
		Debug.Log ("you chose hundred(%)");


	}
}
