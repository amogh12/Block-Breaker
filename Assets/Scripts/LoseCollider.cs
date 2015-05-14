using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {
	private LevelManager levelManager;
	
	void OnTriggerEnter2D(Collider2D collider) {
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		Debug.Log("from OnTrigger enter");
		levelManager.LoadLevel("Lose Screen");
	}
	
	void OnCollisionEnter2D(Collision2D collision) {
		Debug.Log("from on collision");
	}

}
