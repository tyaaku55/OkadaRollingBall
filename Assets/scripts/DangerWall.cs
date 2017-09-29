using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DangerWall : MonoBehaviour 
{

	// Use this for initialization
	void OnCollisionEnter (Collision hit) 
	{

		if (hit.gameObject.CompareTag ("Player")) {
		
			int sceneIndex = SceneManager.GetActiveScene().buildIndex;

			SceneManager.LoadScene (sceneIndex);

		}
	}
	
	// Update is called once per frame
	void Update () {

	}

}