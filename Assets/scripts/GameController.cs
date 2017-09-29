using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public UnityEngine.UI.Text scoreLabel;
	public GameObject WinnerLabelObject;

	public void Update () {
		int count = GameObject.FindGameObjectsWithTag ("item").Length;
			scoreLabel.text = count.ToString ();
		if (count == 0) {
			WinnerLabelObject.SetActive (true);
		}
	}
}
