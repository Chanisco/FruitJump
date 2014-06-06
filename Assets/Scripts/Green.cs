using UnityEngine;
using System.Collections;

public class Green : MonoBehaviour {
	// Use this for initialization
	void OnCollisionEnter(Collision col)
	{		
		if(col.collider.name == "Player1" && Global.green1 == false)	
		{
			Global.death1 = true;
		}
		else if(col.collider.name == "Player1" && Global.green1== true){
			 Global.chaiswro1 = true;	
		}
		if(col.collider.name == "Player2" && Global.green2 == false)	
		{
			Global.death2 = true;
		}
		else if(col.collider.name == "Player2" && Global.green2 == true){
			 Global.chaiswro2 = true;	
		}
	}
	void onCollisionExit(Collision col){
		if(col.collider.name == "Player1" && Global.green1 == true){
			 Global.chaiswro1 = false;	
		}
		if(col.collider.name == "Player2" && Global.green2 == true){
			 Global.chaiswro2 = false;	
		}	
	}
}