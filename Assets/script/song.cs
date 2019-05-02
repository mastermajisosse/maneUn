using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class song : MonoBehaviour {

	public static song instance;

	private static bool created = false;

	public GameObject tt;
	public Sprite soundoff;
	public Sprite soundon;

	private AudioSource audioSource;

	[SerializeField]
	public AudioClip collect , die , win , lose;
	//			audioSource.PlayOneShot (song.instance.die,0.7f); hadi f script dyal player
	
	void Awake () {
		Makeinstance ();
		if (!created)
		{
			DontDestroyOnLoad(this.gameObject);
			created = true;
		}else{
			Destroy(this.gameObject);
		}
	}

	void Start(){
		audioSource = GetComponent<AudioSource>();
	}

	public void sound (){
		if (audioSource.volume == 0.0f)
		{
			audioSource.volume = 1.0f;
			tt.GetComponent<Image>().sprite = soundon;
		}else{
			audioSource.volume = 0.0f;
			tt.GetComponent<Image>().sprite = soundoff;
		}
	}

	void Makeinstance () {
		if (instance == null) {
			instance = this;
		}
	}

	public void pause(){
		audioSource.volume = 0.09f;
	}

	public void cont(){
		audioSource.volume = 0.4f;
	}

}
