using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variables : MonoBehaviour {
	
	public float numb1 = 0f;//dhlwnoume thn metablhth int pou einai o prwtos ari8mos
	public float numb2 = 0f;//dhlwnoume ton deutero ari8mo
	public float result = 0f; //dhlwnoume to apotelesma poy 8a bgainei meta apo ka8e pra3h
	public bool first = false;  //dhlwnoume thn bool check
	public bool multiplayer = false; //an o ari8mos einai pollaplos
	public bool multiplication = false; //h parajh tou pollaplasiasmou
	public bool adition = false; //h pra3h ths pros8eshs
	public bool divide = false; //h pra3h ths diaireshs
	public bool subtraction = false; //h pra3h ths afaireshs
	public bool root = false; //h pra3h gia thn riza
	public bool hundred = false; //h pra3h dia ths ekato
	public float x = 0f; //h timh pou xreiazomaste gia to % 
	public float sale = 0f; //ekptwsh
	public bool negative1 = false; //se peripwtsh pou 8elei na kanei pra3jh me prosimo
	public bool negative2 = false;
	public bool comma = false;
		void Update()
		{
			// Rotate the object around its local X axis at 1 degree per second
			transform.Rotate(Vector3.right * 2);

			// ...also rotate around the World's Y axis
		//	transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
		}



void OnTriggerEnter() {
		//pros8esh pathmenh kai ekato kleisto 
		if (numb1 == 0 && numb2 == 0) {
			Debug.Log ("chose numbers first");
		} else {
			if (adition == true && hundred == false) {
				if (negative1 == true) {
					numb1 = numb1 - (numb1 * 2);
				}
				if (negative2 == true) {
					numb2 = numb2 - (numb2 * 2);
				}
				result = numb1 + numb2;
				Debug.Log (result);
			}
			//pollaplasiasmos  kai ama einai  thetikos o prwtos kai o deuteros
			if (multiplication == true) {
				if (negative1 == true) {
					numb1 = numb1 - (numb1 * 2);
				}
				if (negative2 == true) {
					numb2 = numb2 - (numb2 * 2);
				}
				//Debug.Log ("o prwtos ari8mos egine" + numb1);
				//Debug.Log ("o deuteros ari8mos egine" + numb2);
				result = numb1 * numb2;
				Debug.Log (result);
			}
			//an h diairesh einai pathmenh kai einai arnhtikos o prwtos kai o deyteros
			if (divide == true) {
				if (negative1 == true) {
					numb1 = numb1 - (numb1 * 2);
				}
				if (negative2 == true) {
					numb2 = numb2 - (numb2 * 2);
				}
				result = numb1 / numb2;
				Debug.Log (result);
			}

			//an exei path8ei h afairsh kai to ekato einai kleisto 
			if (subtraction == true && hundred == false) {
				result = numb1 - numb2;
				Debug.Log (result);
			}

			if (root == true) {
				result = Mathf.Sqrt (numb1);
				Debug.Log (result);
			}
			// an to hundred einai true kai h afairesh true h h pros8esh tote kannemou ayto
			if (hundred == true && (subtraction == true || adition == true)) {
				if (adition == true) {
					x = (numb2 / 100) * numb1;
					sale = x + numb1;
					result = sale;
				}
				if (subtraction == true) {
					x = (numb2 / 100) * numb1;
					sale = x - numb1;
					result = sale;


				}
				Debug.Log (result);
			}




			/*
		//an to komma einai truw kai h pros8esh truw tote mou kanei ta apo katw
		if (komma == true && adition == true) {
			if (negative1 == true) {
				numb1 = numb1 - (numb1 * 2);
			}
			if (negative2 == true) {
				numb2 = numb2 - (numb2* 2);
			}
			numb1 = numb1 / 10;
			numb2 = numb2 / 10;
			result = numb1 + numb2;
			Debug.Log (result);
		}
		if (komma == true && subtraction == true) {
			if (negative1 == true) {
				numb1 = numb1 - (numb1 * 2);
			}
			if (negative2 == true) {
				numb2 = numb2 - (numb2* 2);
			}
			numb1 = numb1 / 10;
			numb2 = numb2 / 10;
			result = numb1 - numb2;
			Debug.Log (result);
			
}
		*/
		}

	}
}







/*
void OnTriggerEnter() {
	if (check == true) { //tsekarei thn metablhth h opoia allazei apo to allo script
		Debug.Log ("yes"); //efoson alla3e apo to allo script mas bgazei to yes
	} else {
		Debug.Log ("no"); //auto den prokeite na ginei pote:3
	}
}
*/