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

	public void biksuP(){
		bikses1.SetActive (true);
		bikses2.SetActive (true);
	}

	public void topP(){
		top1.SetActive (true);
		top2.SetActive (true);
		top3.SetActive (true);
	}

	public void shoesP(){
		shoes1.SetActive (true);
		shoes2.SetActive (true);
	}
}
