using UnityEngine;
using System.Collections;

enum ColorType {
	green,
	red,
	blue
}

public class ColorChange : MonoBehaviour {
	public float switchpower;
	public float plynr;
	public Color Rood 	= new Color(10,0,0,1);
	public Color Groen 	= new Color(0,10,0,1); 

	void Start(){
		GameObject.Find("pants").renderer.material.color = Groen;
	}
	
	void Update () {
		SuitColor();
		if(Global.ChangeIsWrong1 == true){
			if(Input.GetKey(KeyCode.S)){
				Global.death1 = true;
			}
		}

		if(Global.ChangeIsWrong2 == true){
			if(Input.GetKey(KeyCode.DownArrow)){
				Global.death2 = true;
			}
		}

		if(switchpower > 0){
			switchpower -= Time.deltaTime;
		}

		if(plynr == 1){
			if(Input.GetKey(KeyCode.S)){
				if(!Global.red1 && Global.green1 && switchpower < 0 && Global.P1PowerRed){
					Global.red1 = true;
					Global.green1 = false;
					switchpower = 1;
					
				}
				else if(Global.red1 && !Global.green1 && switchpower < 0 && Global.P1PowerGreen){
					Global.green1 = true;	
					Global.red1 = false;
					switchpower = 1;

				}

			}

		}
		if(plynr == 2){
			if(Input.GetKey(KeyCode.DownArrow)){
				if(Global.red2 == false && Global.green2 == true && switchpower < 0 && Global.P2PowerRed){
					Global.red2 = true;
					Global.green2 = false;
					switchpower = 1;
					//colorType = ColorType.red;
					
				}
				else if(Global.red2 == true && Global.green2 == false && switchpower < 0 && Global.P2PowerGreen){
					Global.green2 = true;	
					Global.red2 = false;
					switchpower = 1;
				}
			}
		}
		

		/*if (!colorType.red)
			{
				switchpower = switchCooldown;
				changeColor();
			}
		}*/
	}

	public void SuitColor(){
		if(Global.red1 == true && Global.green1 == false){
			GameObject.Find ("pants").renderer.material.color = Rood;
		}
		if(Global.red1 == false && Global.green1 == true){
			GameObject.Find ("pants").renderer.material.color = Groen;
		}
		if(Global.red2 == true && Global.green2 == false){
			GameObject.Find ("kleding").renderer.material.color = Rood;
		}
		if(Global.red2 == false && Global.green2 == true){
			GameObject.Find ("kleding").renderer.material.color = Groen;
		}

	}
}