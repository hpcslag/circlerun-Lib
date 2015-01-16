using UnityEngine;
using System.Collections;

public class DpiResolution {

	float width = Screen.width / 1280 / 2;
	float height = Screen.height / 720 / 2;

	public float setScreenWidth(float setWidth){

		setWidth += width;

		return setWidth;
	}

	public float setScreenHeight(float setHeight){

		setHeight += height;

		return setHeight;
	}

	public float getScreenWidth(){
		return Screen.width;
	}
	public float getScreenHeight(){
		return Screen.height;
	}
}