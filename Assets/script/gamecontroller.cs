using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamecontroller : MonoBehaviour {

	public static gamecontroller instance;

	void Awake(){
		Makeinstance ();
	}

	void Makeinstance () {
		if (instance == null) {
			instance = this;
		}
	}
		
//	public void win(){
////		ads.instance.RequestInterstitial ();
//		Levelnum += 1;
//		Application.LoadLevel ("level"+Levelnum);
//	}

	public void gotomenu(){
		Time.timeScale = 1f;
		Application.LoadLevel ("menu");
	}

	public void level(){
//		audios.PlayOneShot (butaud);
		Application.LoadLevel ("level1");
	}
//	public void quit(){
//		audios.PlayOneShot (butaud);
//		Application.Quit();
//	}
}
