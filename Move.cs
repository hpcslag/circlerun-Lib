using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public float change = 0.1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate(0f,change * Time.timeScale * 3,0f);

		if(transform.position.y>=1.8f){
			change = -change;
		}
		if(transform.position.y<=0.3f){
			change = -change;
		}

	}
}
