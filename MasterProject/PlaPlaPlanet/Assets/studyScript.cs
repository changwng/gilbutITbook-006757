using UnityEngine;
using System.Collections;

public class studyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			float rnd = Random.Range(0.0f, 0.5f);
			this.transform.position = new Vector3 (0.0f, 0.0f, rnd);
		}

		if (Input.GetKeyDown (KeyCode.B)) {
			float rnd = Random.Range(0.0f, 360.0f);
			this.transform.rotation = Quaternion.Euler(rnd, 0.0f, 0.0f);
		}

		if (Input.GetKey (KeyCode.R)) {
			this.transform.Rotate(90.0f * Time.deltaTime, 0.0f, 0.0f);
		}

		if (Input.GetKey (KeyCode.T)) {
			this.transform.Rotate(-90.0f * Time.deltaTime, 0.0f, 0.0f);
		}

		/*
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			this.transform.Translate(new Vector3 (0.0f, 0.0f, 3.0f * Time.deltaTime));
		}

		*/
		if (Input.GetKey (KeyCode.P)) {
			GameObject go = GameObject.Find("Cube") as GameObject;
			go.transform.parent = this.transform;
		}
		if (Input.GetKey (KeyCode.O)) {
			GameObject go = GameObject.Find("Cube") as GameObject;
			go.transform.parent = null;
		}
		if (Input.GetKey (KeyCode.G)) {
			GameObject go = GameObject.Find("Cube") as GameObject;
			go.GetComponent<cubeScript>().bigsize();
		}


	}

}
