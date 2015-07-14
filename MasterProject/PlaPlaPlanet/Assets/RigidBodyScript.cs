using UnityEngine;
using System.Collections;

public class RigidBodyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey (KeyCode.UpArrow)) {
			this.GetComponent<Rigidbody>().AddForce(Vector3.forward * 300 * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			this.GetComponent<Rigidbody>().AddForce(Vector3.back * 300 * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			this.GetComponent<Rigidbody>().AddForce(Vector3.left * 300 * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			this.GetComponent<Rigidbody>().AddForce(Vector3.right * 300 * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.U)) {
			this.GetComponent<Rigidbody>().AddForce(Vector3.up * 300 * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.D)) {
			this.GetComponent<Rigidbody>().AddForce(Vector3.down * 300 * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.Keypad0)) {
			Physics.gravity = Vector3.zero;
		}

		if (Input.GetKey (KeyCode.Keypad8)) {
			Physics.gravity = Vector3.up;
		}

		if (Input.GetKey (KeyCode.Keypad2)) {
			Physics.gravity = Vector3.down;
		}



	}
}
