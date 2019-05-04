using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class root : MonoBehaviour {
	public GameObject result;//public GameObject result; //dhlwnoume to object result pou excei to script variables
	public variables script;//orizoume to script na einai tupou variable

	void Start () {
		script = result.GetComponent<variables> (); //mesa sto script vazoume to script pou einai sto //result to opoio onomazetai variable
	}
	
	void OnTriggerEnter() {
		
		script.root = true;
		Debug.Log ("you chose root");
	}

	void Update()
	{
		// Rotate the object around its local X axis at 1 degree per second
		//transform.Rotate(Vector3.right * 2);

		// ...also rotate around the World's Y axis
			transform.Rotate(Vector3.up * Time.deltaTime, 1);
	}
}
