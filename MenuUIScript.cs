using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuUIScript : MonoBehaviour {

	public GameObject infoPanel;
	RectTransform infoPanelPosition;
	public void onStart()
	{
		SceneManager.LoadScene (2);
	}

	public void onExit()
	{
		Application.Quit ();
	}

	public void onInfo()
	{
		infoPanelPosition = infoPanel.GetComponent<RectTransform> ();
		infoPanelPosition.anchoredPosition = new Vector2 (0,0);
	}

	public void onBack()
	{
		infoPanelPosition = infoPanel.GetComponent<RectTransform> ();
		infoPanelPosition.anchoredPosition = new Vector2 (-720f,0);
	}
}
