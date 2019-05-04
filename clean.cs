using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clean : MonoBehaviour {
	public GameObject result; //dhlwnoume to object result pou excei to script variables
	public variables script; //orizoume to script na einai tupou variable

	void Start () {
		script = result.GetComponent<variables> ();
	}
	void Update()
	{
		// Rotate the object around its local X axis at 1 degree per second
		transform.Rotate(Vector3.right * 2);

		// ...also rotate around the World's Y axis
		//	transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
	}

	void OnTriggerEnter() {
		//arxikopoioume oles tis times
		script.numb1 = 0;//dhlwnoume thn metablhth int pou einai o prwtos ari8mos
		script.numb2 = 0;//dhlwnoume ton deutero ari8mo
		script.result = 0;
		script.first = false;  //dhlwnoume thn bool check
		script.multiplayer = false;
		script.multiplication = false;
		script.adition = false;
		script.divide = false;
		script.subtraction = false;
		script.hundred = false; 
		script.x = 0f; 
		script.sale = 0f; 
		script.negative1 = false; //se peripwtsh pou 8elei na kanei pra3jh me prosimo
		 script.negative2 = false;
		 script.comma = false;
		Debug.Log ("memory has been cleaned");

	}
}
