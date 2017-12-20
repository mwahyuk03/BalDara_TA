using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMove : MonoBehaviour {
	public float spd;
	Rigidbody2D fisika;
	void Start(){
//		fisika = GetComponent<Rigidbody2D> ();
//		fisika.velocity = Vector2.down * spd * Time.deltaTime;
	}

	private void Update () {
		transform.Translate (0, spd * Time.deltaTime, 0);
	}

	private void OnCollisionEnter2D (Collision2D limit) {
		//Debug.Log ("coin nabrak "+limit.gameObject.name);
		if (limit.gameObject.CompareTag ("Player")) {
			Destroy (gameObject);
		
			if(scoreSystem.worldScore >= PlayerPrefs.GetInt ("highscore"))
				PlayerPrefs.SetInt ("highscore", scoreSystem.worldScore);
		}
	}
}
