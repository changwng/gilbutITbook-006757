using UnityEngine;
using System.Collections;

public class GameRootScript : MonoBehaviour {

	public GameObject unitoprefab = null;
	private AudioSource audio;
	public AudioClip jumpsound;
	public Texture2D icon = null;
	public static string mes_text = "test";

	// Use this for initialization
	void Start () {
	
		this.audio = this.gameObject.AddComponent<AudioSource> ();

		this.audio.clip = this.jumpsound;

		this.audio.loop = false;

	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetMouseButtonDown (0)) {
			Instantiate(unitoprefab);

			GameObject go = GameObject.Instantiate(this.unitoprefab) as GameObject;
			go.transform.position = new Vector3(Random.Range(-2.0f, 2.0f), 1.0f, 1.0f);

			this.audio.Play();
		}
	}

	void OnGUI(){

		GUI.DrawTexture (new Rect (Screen.width / 2, 64, 64, 64), icon);
		GUI.Label (new Rect (Screen.width / 2, 128, 128, 32), mes_text);
	}

}
