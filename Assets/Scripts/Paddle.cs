using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	
	public bool autoPlay = false;
	public float minX, maxX;
	
	private Ball ball;
	
	void Start(){
		ball = GameObject.FindObjectOfType<Ball>();
	}
	
	// Update is called once per frame
	void Update () {
		if (!autoPlay){
			MoveWithMouse();
		} else{
			AutoPlay();
		}
	}
	
	void MoveWithMouse(){
		// Mathf.Clamp restricts the position of block between 0.5f and 15.5f
		// mousePosInBlocks convert the mousePosition.x into world units
		float mousePosInBlocks = Mathf.Clamp(Input.mousePosition.x / Screen.width * 16, minX, maxX) ;
		Vector3 paddlePos = new Vector3(mousePosInBlocks, this.transform.position.y, 0f);
		
		this.transform.position = paddlePos;
	}
	
	void AutoPlay(){
		Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, 0f);
		Vector3 ballPos = ball.transform.position;
		paddlePos.x = Mathf.Clamp(ballPos.x, minX, maxX);
		this.transform.position = paddlePos; 
	}
}






