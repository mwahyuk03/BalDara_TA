using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudsGenerator : MonoBehaviour {
	private Transform canvas;
	private GameObject clouds;
	private GameObject meteor;
	private float worldTime;
	private float time;
	private int [] random;
	private int i;

	private void Start () {
		worldTime = 0f;
		time = 0f;
		canvas = GameObject.Find ("Panel").transform;
		random = new int[12]{1, 3, 1, 3, 1, 3, 2, 1, 2, 3, 1, 2};
		i = 0;
	}

	private void Update () {
		if (worldTime <= 40f) {
			if (time >= 4f) {
				GenerateClouds (-1);
				time = 0;
			}
		}else if (worldTime > 40f && worldTime <= 43f) {
			time = 0;
		} 
		else if (worldTime > 43f && worldTime <= 70f) {
			if (time >= 2f) {
				GenerateClouds (-2);
				time = 0;
			}
		}else if (worldTime > 70f && worldTime <= 73f) {
			time = 0;
		} 
		else if (worldTime > 73f && worldTime <= 100f) {
			time = 0;
			} else if (worldTime > 100f && worldTime <= 120f) {
				if (time >= 2f) {
					GenerateClouds (-2);
					time = 0;
				}
		}else if(worldTime > 120f && worldTime <=140f ) {
			time = 0;
		} else if(worldTime > 140f && worldTime <=180f ) {
			if (time >= 2f) {
				GenerateClouds (-3);
				time = 0;
			}
		}  
		else {
				if (time >= 1.5f) {
				GenerateClouds (-2);
					time = 0;
				}
			}
			time += 1 * Time.deltaTime;
			worldTime += 1 * Time.deltaTime;
		
	}
	private void GenerateClouds (int spd) {
		clouds = Resources.Load ("Prefabs/Clouds " + random [i], typeof (GameObject)) as GameObject;
		clouds = Instantiate (clouds);
		clouds.transform.SetParent (canvas, false);
		clouds.GetComponent<cloudsMove> ().spd = spd; 
		i++;
		if (i.Equals (12)) {
			i = 0;
			//Random.range (1, 3);
		}
	}

}
