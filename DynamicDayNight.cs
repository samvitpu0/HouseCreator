using UnityEngine;
using System.Collections;

public class DynamicDayNight : MonoBehaviour {

	public GameObject sun;
	public float speed;

	public AudioSource morning;
	public AudioSource night;

	float init;
	float timeController;

	float state1;
	float state2;
	float state3;
	float state4;
	float state5;

	// Use this for initialization
	void Start () {
		init = Time.time;
		state1 = init + 45f;
		state2 = init + 55f;
		state3 = init + 125f;
		state4 = init + 135f;
		state5 = init + 180f;
		timeController = init;
	}
	
	// Update is called once per frame
	void Update () {
		sun.transform.Rotate (Vector3.left*speed*Time.deltaTime,Space.Self);


		timeController += Time.deltaTime;

		if (timeController < state1) {
			morning.volume = 0.2f;
			night.volume = 0;
		}

		 if (timeController > state1 && timeController < state2) {
			morning.volume -= 0.08f * Time.deltaTime;
			night.volume += 0.08f * Time.deltaTime;
		}
		 if (timeController > state2 && timeController < state3) {
			morning.volume = 0;
			night.volume = 0.2f;
		} 
		if (timeController > state3 && timeController < state4) {
			morning.volume += 0.08f * Time.deltaTime;
			night.volume -= 0.08f * Time.deltaTime;	
		}
		if (timeController>state4) {
			morning.volume = 0.2f;
			night.volume = 0;
		}
		if (timeController > state5) {
			init = Time.time;
			state1 = init + 45f;
			state2 = init + 55f;
			state3 = init + 125f;
			state4 = init + 135f;
			state5 = init + 180f;
			timeController = init;
		}



	}
}
