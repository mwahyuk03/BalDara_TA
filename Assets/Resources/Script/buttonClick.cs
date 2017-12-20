using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class buttonClick : MonoBehaviour {
	Image gambar;
	// Use this for initialization
	void Start () {
		gambar = GetComponent<Image> ();
		gambar.color = new Color (1f,1f,1f,.2f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Inter(){
		gambar.color = new Color (1f,1f,1f,1f);
	}
	public void Exter(){
		gambar.color = new Color (1f,1f,1f,.2f);
	}

}
