using UnityEngine;
using System.Collections;

public class CameraRotatorScript : MonoBehaviour {
	int i;
	void Start()
	{
		i = 0;
	}
	public void onCameraRot(Animator camAnime)
	{
		i++;
		if (i > 9)
			i = 1;
		camAnime.SetInteger ("CamPos",i);

	}

}
