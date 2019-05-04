using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class divides : MonoBehaviour {
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
		script.divide = true;
		if (script.divide == true) {
			Debug.Log ("you chose divide");


		}

	}
}
