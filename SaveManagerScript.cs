using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;

public class SaveManagerScript : MonoBehaviour {

	public GameObject savePanel;
	public GameObject loadPanel;
	public Text savedMapList;
	public GameObject cameraMain;


	Animator savePanelAnime;
	Animator loadPanelAnime;

	bool toggle=true;

	public static bool onSavePage=false;

	// Update is called once per frame
	void Start()
	{
		savePanelAnime = savePanel.GetComponent<Animator> ();
		loadPanelAnime = loadPanel.GetComponent<Animator> ();
	}
	void Update () {

		if (Input.GetKeyDown (KeyCode.LeftAlt)) 
		{
			if (toggle) {
				savePanelAnime.SetBool ("PopIn",true);

				onSavePage = true;
				toggle = false;
			} else {
				savePanelAnime.SetBool ("PopIn",false);

				onSavePage = false;
				toggle = true;
			}
		}


		if (Input.GetKeyDown (KeyCode.LeftControl)) 
		{
			if (toggle) {
				loadPanelAnime.SetBool ("popIn",true);
				savedMapList.text = "";
				foreach (string fileNames in Directory.GetFiles(Application.dataPath,"*_m.xml"))
					savedMapList.text += fileNames + "\n\n";
				
				onSavePage = true;
				toggle = false;
			} else {
				loadPanelAnime.SetBool ("popIn",false);

				onSavePage = false;
				toggle = true;
			}
		}

	}
}
