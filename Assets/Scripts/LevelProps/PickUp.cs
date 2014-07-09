using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {
	public bool green;
	public bool red;
	public int 	condition;

	void Awake(){
		if(green){
			condition = 1;
		}

		if(red){
			condition = 2;
		}
	}

	void OnTriggerEnter(Collider col){
		if(col.collider.tag == Tags.player1){
			if(condition == 1){
				Global.P1PowerGreen 	= true;
			}
			if(condition == 2){
				Global.P1PowerRed 	= true;
				Global.red1			= true;
				Global.green1  		= false;
			}
		}

		if(col.collider.tag == Tags.player2){
			if(condition == 1){
				Global.P2PowerGreen 	= true;
			}
			if(condition == 2){
				Global.P2PowerRed 	= true;
				Global.red2			= true;
				Global.green2  		= false;
			}
		}
	}
}
