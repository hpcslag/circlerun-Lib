using UnityEngine;
using System.Collections;

public class GETTOUCH : MonoBehaviour {
	public float touch_x;
	public float touch_y;
	public static float[] x_arr;
	private int count = 0;
	public Transform prefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonUp (0) && count < 4) {
			Debug.Log (GET_POSITION().x);
			count++;
		}
		if (count>=4){
			Debug.Log("一次最多只能選取四個座標，且不能更改!");
		}
	}

	void INSTANTIATE(Vector2 v){
		Instantiate(prefab,v,Quaternion.identity);
	}

	Vector2 GET_POSITION(){
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hits;

		Vector2 v = new Vector2 ();
		v.x = Input.mousePosition.x;
		v.y = Input.mousePosition.y;

		return v;

	}
	
	void OnGUI(){
		float width = 200;
		float height = 200;
		GUIStyle skin = new GUIStyle ();
		skin.fontSize = 36;
		skin.normal.textColor = Color.white;//new Color (34f, 44f, 55f, 1f);
		GUI.backgroundColor = Color.black;
		GUI.Box (new Rect((Screen.width-Screen.width)/2,0,Screen.width,height),"請選擇陷阱",skin);
		if (GUI.Button (new Rect ((Screen.width - 220), (Screen.height - 70), 200, 50), "選擇角色")) {
			Application.loadedLevel(3); // Modify this variable
		}
	}
}
