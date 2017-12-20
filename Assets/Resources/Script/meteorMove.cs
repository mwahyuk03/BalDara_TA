using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorMove : MonoBehaviour {
	public int spd;


	private void Update () {
		transform.Translate (- 1 * spd * Time.deltaTime, spd * Time.deltaTime, 0);

	}

	private void OnCollisionEnter2D (Collision2D limit) {
	//	Debug.Log ("meteor nabrak "+limit.gameObject.name);
		if (limit.gameObject.CompareTag ("batasBawah") || limit.gameObject.CompareTag ("batasKanan")) {
			
			Destroy (gameObject);
			scoreSystem.worldScore++;
			if(scoreSystem.worldScore >= PlayerPrefs.GetInt ("highscore"))
				PlayerPrefs.SetInt ("highscore", scoreSystem.worldScore);
		}
	}
}
