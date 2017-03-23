using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MapTitleScript : MonoBehaviour {

	public static string fileName;

	InputField mapTitle;

	void Start()
	{
		mapTitle = GetComponent<InputField> ();
	}

	public void onValueChange()
	{
		fileName = mapTitle.text;
	}
}
