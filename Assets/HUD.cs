using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {

	public static bool isPaused = false;
	public static bool showingMap = false;

	public GameObject pauseScreen;
	public GameObject mapCam;

	// Use this for initialization
	void Start () {
	
	}

	public void TogglePause () {

		if (!isPaused) {
			pauseScreen.SetActive (true);
			Time.timeScale = 0;
		} else {
			pauseScreen.SetActive (false);
			Time.timeScale = 1;
		}

		isPaused = !isPaused;


	}

	public void ToggleMap () {

		if (!showingMap) 
			mapCam.SetActive (true);
		 else 
			mapCam.SetActive (false);

		showingMap = !showingMap;
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
