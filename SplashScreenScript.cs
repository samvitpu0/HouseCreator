using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SplashScreenScript : MonoBehaviour {

	float endTime;
	// Use this for initialization
	void Start () {
		endTime = 2.1f + Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		float timeLeft = endTime - Time.time;

		if (timeLeft < 0)
			SceneManager.LoadScene (1);
	}
}
