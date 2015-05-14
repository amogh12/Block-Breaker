using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	static MusicPlayer instance = null;
	// Use this for initialization
	
	void Awake() {
		Debug.Log("Music player awake "+ GetInstanceID());
		if(instance != null) {
			Debug.Log("Music player start "+ GetInstanceID());
			Destroy(gameObject);
			print ("Duplicate music player destroyed");
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
	
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
