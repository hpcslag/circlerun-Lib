using UnityEngine;
using System.Collections;

public class BackMenu : MonoBehaviour {
	private bool showRunTimeMenu = false;
	public GUISkin skin = null;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.S)){
			Stop ();
		}
		if(Input.GetKeyDown(KeyCode.R)){
			Resume();
		}
	}

	void Stop(){
		Debug.Log ("STOP");
		Time.timeScale = 0f;
		ShowMenu();
	}

	void Resume(){
		Debug.Log ("RESUME");
		Time.timeScale = 1f;
		CloseMenu();
	}

	void ShowMenu(){
		showRunTimeMenu = true;
	}

	void CloseMenu(){
		showRunTimeMenu = false;
	}

	void OnGUI(){
		if(showRunTimeMenu){
			GUI.Box(new Rect(0,0, Screen.width, Screen.height),"");
			int width = Screen.width/6;
			int height = Screen.height/8;
			GUI.skin = skin;
			bool resume = GUI.Button(new Rect((Screen.width-width)/2, (Screen.height-height)/6,width,height),"Resume");
			bool restart = GUI.Button(new Rect((Screen.width-width)/2, (Screen.height-height)/3,width,height),"Resume");
			bool menu = GUI.Button(new Rect((Screen.width-width)/2, (Screen.height-height)/2,width,height),"Exit to Menu");
			bool exit = GUI.Button(new Rect((Screen.width-width)/2, (Screen.height-height)/1.5f,width,height),"Exit");


			if(resume){
				Resume();
				CloseMenu();
			}
			if(restart){
				//TODO Application.loadLevel to Start Game 
			}
			if(menu){
				//TODO Application.loadLevel to Menu
			}
			if(exit){
				Application.Quit();
			}
		}
	}
}
