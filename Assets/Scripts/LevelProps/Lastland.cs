using UnityEngine;
using System.Collections;

public class Lastland : MonoBehaviour {

	
	private bool player1Here = false;
	private bool player2Here = false;
	
	public string toLvl;
	void Update(){
		Debug.Log(player1Here);
		Debug.Log(player2Here);
	}
	// Use this for initialization
	void OnCollisionEnter(Collision col){
		
		if(col.collider.name == "Player1")
		{
			player1Here = true;
		}
		else if(col.collider.name == "Player2")
		{
			player2Here = true;
		}
		
		if(player1Here && player2Here)
		{
			Application.LoadLevel(toLvl);	
		}
		
		Debug.Log(player1Here + "" + player2Here);
	}
	
	void OnCollisionExit(Collision col){
		
		if(col.collider.name == "Player1")
		{
			player1Here = false;
		}
		else if(col.collider.name == "Player2")
		{
			player2Here = false;
		}
	}
}
