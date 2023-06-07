﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public  void PlayGame(){
		SceneManager.LoadScene ("Game", LoadSceneMode.Single);
	}
	public  void Back(){
		SceneManager.LoadScene ("MainMenu", LoadSceneMode.Single);
	}
	public  void restart(){
		SceneManager.LoadScene ("Game", LoadSceneMode.Single);
	}

	public void QuitGame(){
		Debug.Log ("QUIT");
		Application.Quit ();
	}
}
