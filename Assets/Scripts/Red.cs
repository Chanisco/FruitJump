using UnityEngine;
using System.Collections;

public class Red : MonoBehaviour {
	void Start(){
			
	}
	void Update(){
	}
	// Use this for initialization
	void OnCollisionEnter(Collision col)
	{		
		if(col.collider.name == "Player1" && Global.red1 == false)	
		{
			Global.death1 = true;
		}
		else if(col.collider.name == "Player1" && Global.red1 == true){
			 Global.chaiswro1 = true;	
		}
		if(col.collider.name == "Player2" && Global.red2 == false)	
		{
			Global.death2 = true;
		}
		else if(col.collider.name == "Player2" && Global.red2 == true){
			 Global.chaiswro2 = true;	
		}
	}
	void onCollisionExit(Collision col){
		if(col.collider.name != "Player1" && Global.red1 == true){
			Global.chaiswro1 = false;	
		}
		if(col.collider.name != "Player2" && Global.red2 == true){
			 Global.chaiswro2 = false;	
		}	
	}
}