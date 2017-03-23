using UnityEngine;
using System.Collections;

public class CameraKeboardRotation : MonoBehaviour {

	Animator camAnime;
	public GameObject cameraMain;
	int i=0;
	// Use this for initialization
	void Start () {
		camAnime = cameraMain.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.C)) {
			i++;
			if (i > 9)
				i = 1;
			camAnime.SetInteger ("CamPos",i);
		}
	}
}
