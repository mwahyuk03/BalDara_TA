using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
	private GameObject panelext,groubtn;
	public GameObject pause, play, refresh,gomenu;
	public float hAxis, vAxis;
	public AudioSource soundbtn,soundbg;
	public GameObject load;

	public void ButtonDown(int index){
		if (index == 0) {
			vAxis = 1f;
		} else if (index == 1) {
			hAxis = 1f;
		} else if (index == 2) {
			vAxis = -1f;
		} else if(index==3){
			hAxis = -1f;
		}
	}

	public void ButtonUpn(int index){
		if (index == 0) {
			vAxis = 0f;
		} else if (index == 1) {
			hAxis = 0f;
		} else if (index == 2) {
			vAxis = 0f;
		} else if(index==3){
			hAxis = 0f;
		}
	}

	public void Start(){
		panelext = GameObject.FindGameObjectWithTag ("PanelExit");



		if (panelext != null) {
			panelext.SetActive (false);
		}


	}

	void Update(){
		
	}

	public void OnClick_Ulang(){
		soundbtn.Play ();
		Time.timeScale = 1;
		SceneManager.LoadScene ("gameplay");


	}

	public void OnClick_Gameplay(){
		load.SetActive (true);
		soundbtn.Play ();
		Time.timeScale = 1;
		SceneManager.LoadScene ("gameplay");


	}



	public void OnClick_Menu ()
	{
		soundbtn.Play ();
		SceneManager.LoadScene ("Menu");
	}

	public void OnClickExit ()
	{
		panelext.SetActive (true);
		//groubtn.SetActive (true);
		soundbtn.Play ();

	}

	public void OnClickNo ()
	{
		soundbtn.Play ();
		panelext.SetActive (false);

	}

	public void OnClickYes ()
	{
		soundbtn.Play ();
		Application.Quit ();


	}

	public void OnClickPause(){
		soundbtn.Play ();
		soundbg.Pause ();
		Time.timeScale = 0;
		pause.SetActive (false);
		play.SetActive (true);

	}

	public void OnClickPlay(){
		soundbtn.Play ();
		soundbg.Play ();
		Time.timeScale = 1;
		pause.SetActive (true);
		play.SetActive (false);

	}
}
