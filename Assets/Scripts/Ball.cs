using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	private Paddle paddle;
	private bool hasStarted = false;
	private Vector3	paddleToBallVector;
	// Use this for initialization
	void Start () {
		//	linking object 
		paddle = GameObject.FindObjectOfType<Paddle>();
		paddleToBallVector = this.transform.position - paddle.transform.position;
		print(paddleToBallVector.y);
	}
	
	// Update is called once per frame
	void Update () {
		if(!hasStarted) {
			//lock the ball relative to paddle
			this.transform.position = paddle.transform.position + paddleToBallVector;
		
			//wait for a mouse press to start
			if(Input.GetMouseButtonDown(0)) {
				print ("mouse button is clicked, launch ball");
				hasStarted = true;
				this.rigidbody2D.velocity = new Vector2(2f, 10f);
			}
		}
	}
	
	void OnCollisionEnter2D(Collision2D collision) {
		Vector2 tweak = new Vector2(Random.Range(0f,0.2f), Random.Range(0f,0.2f));
		
		if(hasStarted) {
			audio.Play();
			rigidbody2D.velocity += tweak;
		}
		
	}
}
