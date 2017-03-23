using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class EditorUIScript : MonoBehaviour {

	public void onBack()
	{
		SceneManager.LoadScene (1);
	}
}
