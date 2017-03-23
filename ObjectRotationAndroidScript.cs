using UnityEngine;
using System.Collections;

public class ObjectRotationAndroidScript : MonoBehaviour {

	public static GameObject obj;

	void Update()
	{
		if (Input.touchCount == 2) 
		{
			float touchValue = Input.GetTouch (1).deltaPosition.x;
			obj.transform.Rotate (-1*Vector3.up * 2 * touchValue, Space.World);
		}
	}

}
