using UnityEngine;
using System.Collections;


public class UIButtonLevelLoad : MonoBehaviour {
	
	public string LevelToLoad;
	
	public void loadLevel() {
		//Load the level from LevelToLoad
		Application.LoadLevel(LevelToLoad);
	}
}
