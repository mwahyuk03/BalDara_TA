using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class playerMove : MonoBehaviour {
	public float speed;
	private Rigidbody2D rig;
	private GameObject panel;
	private GameObject panel1;
	private GameObject panel2;
	private GameObject coinOff;
	private Text ScoreTxt;
	private Text HighScore;
	private GameObject bgsound;
//	private ButtonManager tombol;

	private void Start () {
		//tombol = GameObject.FindGameObjectWithTag ("ButtonManager").GetComponent<ButtonManager>();
		bgsound = GameObject.FindGameObjectWithTag("SounBG");
		rig = GetComponent<Rigidbody2D> ();
		coinOff = GameObject.FindGameObjectWithTag ("Coin");
		panel2 = GameObject.FindGameObjectWithTag ("PanelGameplay");

		panel = GameObject.FindGameObjectWithTag ("PanelGameOver");
		ScoreTxt = GameObject.FindGameObjectWithTag ("SkorNow").GetComponent<Text>();
		HighScore = GameObject.FindGameObjectWithTag ("HighScore").GetComponent<Text>();

		panel.SetActive (false);
	
	}
	
	private void Update () {
		float hAxis = CrossPlatformInputManager.GetAxis("Horizontal");
		//Debug.Log ("haxis= "+hAxis);
		float vAxis = CrossPlatformInputManager.GetAxis("Vertical");
		//Debug.Log ("haxis= "+vAxis);
//		Vector3 movement = new Vector3 (hAxis, vAxis, 0) * speed * Time.deltaTime;
		rig.velocity = new Vector2 (hAxis, vAxis) * speed * Time.deltaTime;
		//rig.MovePosition (transform.position + movement);
	}

	private void OnCollisionEnter2D (Collision2D player) {
		//Debug.Log ("player nabrak "+player.gameObject.name);
		if (player.gameObject.CompareTag ("Clouds") || player.gameObject.CompareTag ("Meteor")) {
			Time.timeScale = 0;
			GetComponent<SpriteRenderer> ().enabled = false;
			panel2.SetActive (false);
			coinOff.SetActive (false);
			bgsound.SetActive (false);
			panel.SetActive (true);
			ScoreTxt.text = scoreSystem.worldScore.ToString ();
			HighScore.text = PlayerPrefs.GetInt ("highscore").ToString ();
		} else if (player.gameObject.CompareTag ("Coin")) {
			scoreSystem.worldScore+=5;
			Destroy (player.gameObject);
		}

	}
}
