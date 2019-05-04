using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multiplication : MonoBehaviour {
	public GameObject result;
	public variables script;
	// Use this for initialization
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
		script.multiplayer = true;
		script.multiplication = true;
		if (script.numb1 == 0 && script.numb2 == 0) {
			Debug.Log ("you have no enter the firstnumber");
			script.multiplayer = false;
			script.multiplication = false;
		}

		else  {
			Debug.Log ("you chose multiplication");


		}
	
	}



}
