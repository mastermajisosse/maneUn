using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controll : MonoBehaviour {

	public static controll instance;

	public Text heights ;public Text heightscorefin ;
	public Text score;
	public int scoreint;

	void Start(){
		Makeinstance ();
		heights.text = PlayerPrefs.GetInt ("HighScore",0).ToString();
	}

	void Makeinstance () {
		if (instance == null) {
			instance = this;
		}
	}

	public void aug(int sc){
		scoreint = sc;
		if (scoreint > PlayerPrefs.GetInt ("HighScore",0) ) {
			PlayerPrefs.SetInt ("HighScore", sc);
			heights.text = scoreint.ToString ();
		}
		score.text = scoreint.ToString ();
		heightscorefin.text = heights.text;
	}

	public void Resset (){
		PlayerPrefs.DeleteKey ("HighScore");
	}
		
}