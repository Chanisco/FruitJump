using UnityEngine;
using System.Collections;

enum ColorType {
	green,
	red,
	blue
}

public class Mittens : MonoBehaviour {
	public float switchpower;
	public float plynr;
	
	// Update is called once per frame
			
	void Start(){
		Color Groen = new Color(0,10,0,1);
		GameObject.Find ("pants").renderer.material.color = Groen;
		GameObject.Find ("Signal" + plynr).renderer.material.color = Groen;
	}
	
	void Update () {
		Debug.Log(Global.chaiswro1);
		if(Global.chaiswro1 == true){
			if(Input.GetKey(KeyCode.S)){
				Global.death1 = true;
			}
		}
		if(Global.chaiswro2 == true){
			if(Input.GetKey(KeyCode.DownArrow)){
				Global.death2 = true;
			}
		}
		switchpower -= Time.deltaTime;
		//Debug.Log(switchpower);
		if(plynr == 1){
			if(Input.GetKey(KeyCode.S)){
				if(Global.red1 == false && Global.green1 == true && switchpower < 0){
					Color Rood = new Color(10,0,0,1);	
					GameObject.Find ("pants").renderer.material.color = Rood;
					Global.red1 = true;
					Global.green1 = false;
					switchpower = 1;
					
				}
				else if(Global.red1 == true && Global.green1 == false && switchpower < 0){
					Color Groen = new Color(0,10,0,1);	
					GameObject.Find ("pants").renderer.material.color = Groen;
					Global.green1 = true;	
					Global.red1 = false;
					switchpower = 1;
				}
			}
		}
		if(plynr == 2){
			if(Input.GetKey(KeyCode.DownArrow)){
				if(Global.red2 == false && Global.green2 == true && switchpower < 0){
					Color Rood = new Color(10,0,0,1);	
					GameObject.Find ("kleding").renderer.material.color = Rood;
					Global.red2 = true;
					Global.green2 = false;
					switchpower = 1;
					//colorType = ColorType.red;
					
				}
				else if(Global.red2 == true && Global.green2 == false && switchpower < 0){
					Color groen = new Color(0,10,0,1);	
					GameObject.Find ("kleding").renderer.material.color = groen;
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
}