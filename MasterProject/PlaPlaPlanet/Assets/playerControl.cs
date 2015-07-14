using UnityEngine;
using System.Collections;

public class playerControl : MonoBehaviour {

	private float power;
	public float POWERPLUS = 100.0f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetMouseButton (0)) {
			power += POWERPLUS * Time.deltaTime;
		}

		if (Input.GetMouseButtonUp (0)) {
			this.GetComponent<Rigidbody>().AddForce(new Vector3(power, power, 0));
			power = 0.0f;
		}

		if (this.transform.position.y < -5.0f) {
			Application.LoadLevel("gameScene");
		}
		   

	}
}
