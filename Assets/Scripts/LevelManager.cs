using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	bool paused = false;
	bool mute = false;
	
	public void LoadLevel(string name){
		Debug.Log("Level load requested for: "+name);
		Brick.breakableCount = 0;
		Application.LoadLevel(name);
	}
	
	public void QuitRequest(){
		Debug.Log("I Want to quit!");
		Application.Quit();
	}
	
	public void LoadNextLevel() {
		Brick.breakableCount = 0;
		Application.LoadLevel(Application.loadedLevel + 1);
	}
	
	public void BrickDestroyed() {
		if(Brick.breakableCount <=0 ) {
			LoadNextLevel();
		}
	}
	
	public void PauseGame() {
		if(!paused) {
			Time.timeScale = 0;
			paused = true;
		} else {
			Time.timeScale = 1;
			paused = false;
		}
	}
	
	public void MuteSound() {
		if(!mute) {
			AudioListener.pause = true;
			mute = true;
		} else {
			AudioListener.pause = false;
			mute = false;
		}
	}
}
