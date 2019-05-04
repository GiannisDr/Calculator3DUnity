using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class komma : MonoBehaviour {
	public GameObject result;
	public variables script;

	void Start () {
		script = result.GetComponent<variables> ();
	}


	void OnTriggerEnter() {
		
		script.comma = true;

		if (script.numb2 == 0) {
			string number1 = script.numb1.ToString ();
			string dot = ".";
			number1 = number1 + dot;
			script.numb1 = float.Parse (number1);
			Debug.Log (script.numb1 + ".");
		} else {
			string number1 = script.numb2.ToString ();
			string dot = ".";
			number1 = number1 + dot;
			script.numb2 = float.Parse (number1);
			Debug.Log (script.numb2 + ".");

		}
	}
}




/*
		string num1 = script.numb1.ToString ();
	decimal	num12 = num1 ;
		script.numb1 = float.Parse (num1);
		Debug.Log (script.numb1);
	*/