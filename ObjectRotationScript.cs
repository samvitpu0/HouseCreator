using UnityEngine;
using System.Collections;

public class ObjectRotationScript : MonoBehaviour {

	public static GameObject obj;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!SaveManagerScript.onSavePage) 
		{
			if (Input.GetKeyDown (KeyCode.E))
				obj.transform.Rotate (Vector3.up * 45, Space.World);
			if (Input.GetKeyDown (KeyCode.Q))
				obj.transform.Rotate (-1 * Vector3.up * 45, Space.World);
		}
	}
}
