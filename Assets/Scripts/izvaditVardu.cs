using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class izvaditVardu : MonoBehaviour {
	public string vards;
	public string gadi;
	public GameObject ievadesLauksV;
	public GameObject ievadesLauksG;
	public GameObject izvadesLauks;

	public void vardaIzvade(){
		vards = ievadesLauksV.GetComponent<Text> ().text;
		gadi = ievadesLauksG.GetComponent<Text> ().text;
		izvadesLauks.GetComponent<Text>().text = "Varoņa vārds ir "+vards+" un varonim ir "+gadi+" gadu!";
	}


}
