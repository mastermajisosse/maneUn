using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levels : MonoBehaviour {

	public void level(int levelnum){
		Application.LoadLevel ("level" + levelnum);
	}

	public void levelscene(string name){
		Application.LoadLevel (name);
	}

}
