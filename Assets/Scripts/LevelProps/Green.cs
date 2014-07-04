using UnityEngine;
using System.Collections;

public class Green : MonoBehaviour {
	// Use this for initialization
	void OnCollisionEnter(Collision col)
	{		
		if(col.collider.tag == Tags.player1 && Global.green1 == false)	
		{
			Global.death1 = true;
		}
		else if(col.collider.tag == Tags.player1 && Global.green1 == true){
			 Global.ChangeIsWrong1 = true;	
		}
		if(col.collider.tag == Tags.player2 && Global.green2 == false)	
		{
			Global.death2 = true;
		}
		else if(col.collider.tag == Tags.player2 && Global.green2 == true){
			 Global.ChangeIsWrong2 = true;	
		}
	}
	void onCollisionExit(Collision col){
		if(col.collider.tag == Tags.player1 && Global.green1 == true){
			 Global.ChangeIsWrong1 = false;	
		}
		if(col.collider.tag == Tags.player2 && Global.green2 == true){
			 Global.ChangeIsWrong2 = false;	
		}	
	}
}