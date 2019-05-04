using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class two : MonoBehaviour {

	public GameObject result;//public GameObject result; //dhlwnoume to object result pou excei to script variables
	public variables script;//orizoume to script na einai tupou variable

	void start() {
		script = result.GetComponent<variables> (); //mesa sto script vazoume to script pou einai sto //result to opoio onomazetai variable

	}

	void OnTriggerEnter() {

		if (script.comma == true) {
			if (script.numb2 == 0) {
				string number1 = script.numb1.ToString ();
				number1 = number1 + ".2";
				script.numb1 = float.Parse (number1);
				script.comma = false;
			} else {
				string number2 = script.numb2.ToString ();
				number2 = number2 + ".2";
				script.numb2 = float.Parse (number2);
				script.comma = false;


			}
		} 
		else if (script.multiplayer == false) { //an pame se kapoion apo tous operator tote h syn8hkh auth mas odhgaei sto else alliws ginetai kanonika to prwto meros ths sun8hkhs
			script.numb1= script.numb1 *10  + 2;

		} else {
			script.numb2 = (script.numb2 * 10) + 2;
		}

		//emfanizoume kai ton deutero ari8mo

		Debug.Log (script.numb1); //emfanizoume ton prwto ari8mo
		Debug.Log (script.numb2);
	}	

}
