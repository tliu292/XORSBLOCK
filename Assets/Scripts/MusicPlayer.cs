using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
	
	static MusicPlayer instance = null;
	
	void Awake(){
		if (instance != null){
			Destroy (gameObject);
			print ("Self destructing duplicate music player");
		} else{
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);	
		}	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
