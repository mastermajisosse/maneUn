using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class garage : MonoBehaviour {

	private GameObject[] CarList;
	public int index;
	void Start () {
		index = PlayerPrefs.GetInt("CarSelect");

		CarList = new GameObject[transform.childCount];

		//ghi bach yjib ga3 les obj o ystorihom f array
		for (int i = 0; i < transform.childCount; i++)
		{
			CarList[i] = transform.GetChild(i).gameObject;
		}

		//bach yweliw kamlin hiden
		foreach (GameObject go in CarList)
		{
			go.SetActive(false);
		}

		//khtar lcar li deja mselectiha 
		if (CarList[index])
		{
			CarList[index].SetActive(true);
		}
	}
	
	public void toggleCar (int i) {
		CarList[index].SetActive(false);
		Debug.Log(i+" // index :"+index);
		index = i;
		CarList[index].SetActive(true);
		// PlayerPrefs.SetInt("CarSelect",index);
	}

	public void confirm () {
		PlayerPrefs.SetInt("CarSelect",index);
		// Application.LoadLevel ("gameplay");
	}
}

