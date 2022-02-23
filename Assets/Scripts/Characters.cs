using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Characters : MonoBehaviour {
	public Sprite[] charactersArr;
	public GameObject attelaTuretajs;
	public GameObject infoF;
	public GameObject infoT;

	public void izkritosais(int skaitlis){
		if (skaitlis == 0){
			infoT.SetActive (false);
			attelaTuretajs.GetComponent<Image> ().sprite = charactersArr [0];
			infoF.SetActive (true);
		}else if (skaitlis == 1){
			infoF.SetActive (false);
			attelaTuretajs.GetComponent<Image> ().sprite = charactersArr [1];
			infoT.SetActive (true);
		}
	}
}
