using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	
	private Paddle paddle;
    public bool hasStarted = false;
	private Vector3 paddleToBallVector;
	
	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle>();
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	public void Update () {
		if (!hasStarted){	
			this.transform.position = paddle.transform.position + paddleToBallVector;
			if (Input.GetMouseButtonDown(0)){
				hasStarted = true;
				this.rigidbody2D.velocity = new Vector2(2f, 10f);
			}
		}
	}
	
	void OnCollisionEnter2D(Collision2D collision){
		// Ensure that there's no dull bouncing situation
		Vector2 tweak = new Vector2(Random.Range (-0.2f, 0.2f), Random.Range (-0.2f, 0.2f));
		if (hasStarted){	
			audio.Play ();
			this.rigidbody2D.velocity += tweak;
		}
		
	}
}
