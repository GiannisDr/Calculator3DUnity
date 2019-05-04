using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class subtraction : MonoBehaviour {
	public GameObject result;
	public variables script;

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
		
		if (script.numb1 == 0) {
			script.negative1 = true;
			Debug.Log ("you chose for  first number negative");
		} else if (script.numb1 != 0) {
			script.multiplayer = true;
			script.subtraction = true;
			Debug.Log ("you chose substraction");
		}


		}

}

// if (script.numb2 == 0 && script.numb1 != 0)

