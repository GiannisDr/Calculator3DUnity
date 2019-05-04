using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zero : MonoBehaviour {
	public GameObject result;
	public variables script;

	void start() {
		script = result.GetComponent<variables> (); //mesa sto script vazoume to script pou einai sto //result to opoio onomazetai variable

	}
	void OnTriggerEnter() {
		if (script.multiplayer == false) {
			script.numb1 = (script.numb1 * 10) + 0;

		} else {
			script.numb2 = (script.numb2 * 10) + 0;
		}
		Debug.Log (script.numb1);
		Debug.Log (script.numb2);
	}
}
