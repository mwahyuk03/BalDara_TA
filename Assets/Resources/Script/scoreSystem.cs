using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreSystem : MonoBehaviour {
	public static int worldScore;
	private Text worldText;

	private void Start () {
		worldScore = 0;
		worldText = GetComponent<Text> ();
		worldText.text = (worldScore).ToString ();
	}

	private void Update () {
		worldText.text = (worldScore).ToString ();
	}


}
