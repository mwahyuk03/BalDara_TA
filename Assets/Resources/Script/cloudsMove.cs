using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cloudsMove : MonoBehaviour {
	public int spd;


	private void Update () {
		transform.Translate (0, spd * Time.deltaTime, 0);

	}

	private void OnCollisionEnter2D (Collision2D limit) {
		//Debug.Log ("clouds nabrak "+limit.gameObject.name);
		if (limit.gameObject.CompareTag ("batasBawah") ) {
			
			Destroy (gameObject);
			scoreSystem.worldScore++;
			if(scoreSystem.worldScore >= PlayerPrefs.GetInt ("highscore"))
				PlayerPrefs.SetInt ("highscore", scoreSystem.worldScore);
		}
	}
}
