using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clothes : MonoBehaviour {

	public GameObject bikses1;
	public GameObject bikses2;

	public GameObject top1;
	public GameObject top2;
	public GameObject top3;

	public GameObject shoes1;
	public GameObject shoes2;


	public void biksuP(bool val){
		bikses1.SetActive (val);
		bikses2.SetActive (val);
	}

	public void topP(bool val){
		top1.SetActive (val);
		top2.SetActive (val);
		top3.SetActive (val);
	}

	public void shoesP(bool val){
		shoes1.SetActive (val);
		shoes2.SetActive (val);
	}


}
