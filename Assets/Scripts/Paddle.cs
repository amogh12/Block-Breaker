using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	public bool autoPlay = false;
	
	private Ball ball;
	
	// Use this for initialization
	void Start () {
		ball = GameObject.FindObjectOfType<Ball>();
	}
	
	// Update is called once per frame
	void Update () {
		if(!autoPlay) {
			MoveWithMouse();
		} else {
			AutoPlay();
		}
	}
	
	void AutoPlay(){
		Vector3 paddalePos = new Vector3(1.33f, this.transform.position.y, 0f);
		Vector3 ballPos = ball.transform.position;		
		paddalePos.x = Mathf.Clamp(ballPos.x, 1.33f, 14.66f);
		this.transform.position = paddalePos;
	}
	
	void MoveWithMouse() {
		Vector3 paddalePos = new Vector3(0.5f, this.transform.position.y, 0f);
		//this gives the relative position
		float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
		paddalePos.x = Mathf.Clamp(mousePosInBlocks, 1.33f, 14.66f);
		this.transform.position = paddalePos;
	}
}
