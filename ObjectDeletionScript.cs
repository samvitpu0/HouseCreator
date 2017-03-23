using UnityEngine;
using System.Collections;

public class ObjectDeletionScript : MonoBehaviour {

	GameObject objectTobeDeleted;
	public AudioSource objectDeleteSound;
	bool timerStart=false;
	float endTime;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("Aayo");
		if (timerStart)
		{
			
			float timeLeft = endTime - Time.time;
			if (timeLeft < 0) 
			{
				Destroy (objectTobeDeleted);
				objectDeleteSound.Play ();
				timerStart = false;
			}

		}
		
	}

	void OnTriggerEnter(Collider other)
	{
		endTime = 2.0f + Time.time;
		objectTobeDeleted = other.gameObject;
		timerStart = true;
	}

	void OnTriggerExit(Collider other)
	{
		timerStart = false;
	}
}
