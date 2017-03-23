using UnityEngine;
using System.Collections;

public class InstantiatorScript : MonoBehaviour {

	public GameObject instantiateObject;
	public AudioSource createObject;
	public float scaleFactor;
	public GameObject parent;

	void Update()
	{
		transform.Rotate (Vector3.up*10*Time.deltaTime,Space.World);
	}
	void OnMouseDown()
	{
		GameObject createdObject = Instantiate (instantiateObject, new Vector3 (0f, 0f, 0f),Quaternion.identity) as GameObject;
		createdObject.transform.localScale = instantiateObject.transform.localScale * scaleFactor;
		createdObject.transform.parent = parent.transform;
		createObject.Play ();
	}
}
