using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorGenerator1 : MonoBehaviour {
	private Transform canvas;

	private GameObject meteor;

	private float worldTime;
	private float time;

	private int [] random1;

	private int i;

	private void Start () {
		worldTime = 0f;
		time = 0f;
		canvas = GameObject.Find ("Panel").transform;
		random1 = new int[12]{1,2,3,6,5,4,3,2,1,4,5,6};
		i = 0;
	}

	private void Update () {
		if (worldTime <= 73f) {
			time = 0;
		} else if (worldTime > 73f && worldTime <= 100f) {
			if (time >= 2f) {
				GenerateMeteor (-2);
				time = 0;
			}
		} else if (worldTime > 100f && worldTime <= 120f) {
			time = 0;
		} else if (worldTime > 120f && worldTime <= 140f) {
			if (time >= 2f) {
				GenerateMeteor (-3);
				time = 0;
			}
		}else if (worldTime > 150f && worldTime <= 180f) {
			if (time >= 3f) {
				GenerateMeteor (-3);
				time = 0;
			}
		}else{
			if (time >= 2.5f) {
				GenerateMeteor (-5);
				time = 0;
			}
		}
		time += 1 * Time.deltaTime;
		worldTime += 1 * Time.deltaTime;
	}


	private void GenerateMeteor (int spd) {
		meteor = Resources.Load ("Prefabs/Meteor" + random1 [i], typeof (GameObject)) as GameObject;
		meteor = Instantiate (meteor);
		meteor.transform.SetParent (canvas, false);
		meteor.GetComponent<meteorMove> ().spd = spd; 
		i++;
		if (i.Equals (12)) {
			i = 0;
		}
	}



}
