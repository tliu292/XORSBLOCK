using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LoseCollider : MonoBehaviour {
	public Text text;
	public Ball ball;
	
	private int life = 3;
	private LevelManager levelManager;
	
	void Start(){
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	void OnTriggerEnter2D(Collider2D collider){
		life--;
		ChangeNumber();
		ball.hasStarted = false;
		ball.Update();
		if (life == 0){
			levelManager.LoadLevel("Lose");
		}
	}
	
	void ChangeNumber(){
		if (life == 3) { text.text = "III";}
		else if (life == 2) { text.text = "II";}
		else if (life == 1) { text.text = "I";}
		else{ text.text = "O";}
	}
	
}
