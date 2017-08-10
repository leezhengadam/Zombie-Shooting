using UnityEngine;
using System.Collections;

public class Crosshair : MonoBehaviour {

	public Texture2D CrosshairImg;
	void Start () {
	
	}
	
	void OnGUI(){
		if(CrosshairImg){
			GUI.color = new Color(1, 1, 1, 0.8f);
			GUI.DrawTexture(new Rect((Screen.width * 2f) - (CrosshairImg.width * 2f),(Screen.height * 2) - (CrosshairImg.height * 2f), CrosshairImg.width,CrosshairImg.height), CrosshairImg);
			GUI.color = Color.white;
		}
	}
}
