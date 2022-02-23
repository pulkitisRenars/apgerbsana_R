using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Characters : MonoBehaviour {
	public Sprite[] charactersArr;
	public GameObject attelaTuretajs;


	public void izkritosais(int skaitlis){
		if (skaitlis == 0)
			attelaTuretajs.GetComponent<Image> ().sprite = charactersArr [0];
		else if (skaitlis == 1)
			attelaTuretajs.GetComponent<Image> ().sprite = charactersArr [1];
		else if (skaitlis == 2)
			attelaTuretajs.GetComponent<Image> ().sprite = charactersArr [2];
	}
}
