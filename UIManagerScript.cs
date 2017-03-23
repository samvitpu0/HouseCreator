using UnityEngine;
using System.Collections;

public class UIManagerScript : MonoBehaviour {

	public void slidein(Animator anime)
	{
		anime.SetBool ("SlideIn",true);
	}

	public void slideout(Animator anime)
	{
		anime.SetBool ("SlideIn",false);
	}
}
