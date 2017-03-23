using UnityEngine;
using System.Collections;

public class DragNDropScript : MonoBehaviour {

	void OnMouseDrag()
	{
		Plane plane=new Plane(Vector3.up,new Vector3(0, 0f, 0));
		Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);
		float distance;
		if(plane.Raycast(ray, out distance)) 
			transform.position=ray.GetPoint(distance);
	}

	void OnMouseDown()
	{
		ObjectRotationScript.obj = gameObject;
		ObjectRotationAndroidScript.obj = gameObject;
	}
}
