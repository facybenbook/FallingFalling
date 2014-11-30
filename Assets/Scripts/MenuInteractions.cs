﻿using UnityEngine;
using System.Collections;

public class MenuInteractions : MonoBehaviour {
	public GameObject bg;
	public GameObject sceneScore;
	public GameObject dedCanvas;
	public GameObject pauseCanvas;
	void Awake() {
//		bg = GameObject.Find ("bg");
//		dedCanvas = GameObject.Find ("DedCanvas");
		//DedMenu ();
	}

	public void DedMenu() {
		//bg.GetComponent<Image>().enabled = false;
		Time.timeScale = 0;
		bg.SetActive (true);
		sceneScore.SetActive (false);
		dedCanvas.SetActive (true);
	}
	public void PauseMenu() {
		pauseCanvas.SetActive (!pauseCanvas.activeSelf);
		bg.SetActive (pauseCanvas.activeSelf);
		if (pauseCanvas.activeSelf) {
			Time.timeScale = 0;
		} else {
			Time.timeScale = 1;
		}
	}
	public void ReloadScene() {
		Application.LoadLevel (0);
		Time.timeScale = 1;
	}
}
