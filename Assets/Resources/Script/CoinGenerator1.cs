using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator1 : MonoBehaviour {
//	private Transform canvas;

	private GameObject coin;
	private float worldTime;
	private float time;

	private int [] random2;
	private int i;

	private void Start () {
		worldTime = 0f;
		time = 0f;
//		canvas = GameObject.Find ("Panel").transform;

		random2 = new int[8]{ 1,3,1,2,3,2,1,3};
		i = 0;
	}

	private void Update () {

		if (worldTime <= 55f) {
			time = 0;

		} else if(worldTime > 55f && worldTime <=70f ) {
			if (time >= 4f) {
				GenerateCoin (-1);
				time = 0;
			}
		}else if(worldTime > 70f && worldTime <=130f ) {
			if (time >= 2.5f) {
			//GenerateCoin (-2);
			time = 0;
			}
		} else if(worldTime > 130f && worldTime <=140f ) {
			if (time >= 2f) {
				GenerateCoin (-2);
				time = 0;
			}
		} else if(worldTime > 140f && worldTime <=165f ) {
			time = 0;
		}  else if(worldTime > 165f && worldTime <=180f ) {
			if (time >= 1.5f) {
				GenerateCoin (-2);
				time = 0;
			}
		} else {
			if (time >= 5f) {
				GenerateCoin (-1);
				time = 0;
			}
		}
		time += 1 * Time.deltaTime;
		worldTime += 1 * Time.deltaTime;
	}



	private void GenerateCoin (int spd) {
		coin = Resources.Load ("Prefabs/Coin" + random2 [i], typeof (GameObject)) as GameObject;
		coin = Instantiate (coin);
		//coin.transform.SetParent (canvas, false);
		coin.GetComponent<CoinMove> ().spd = spd; 
		i++;
		if (i.Equals (8)) {
			i = 0;
		}
	}

}
