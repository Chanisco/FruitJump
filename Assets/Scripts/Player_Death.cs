using UnityEngine;
using System.Collections;

public class Player_Death : MonoBehaviour {
	public float playernr;
	public GameObject P1;
	public GameObject P2;
	public float deathwait;
	Vector3 Spawn1;
	Vector3 Spawn2;
	public float x1;
	public float x2;
	public float y1;
	public float y2;
	public float z1;
	public float z2;
	// Use this for initialization
	void Start () {
		//	Spawn1 = new Vector3(-20,8,-0.3f);
			Spawn1 = new Vector3(x1,y1,z1);	
			//Spawn2 = new Vector3(-20,8,0.65f);
			Spawn2 = new Vector3(x2,y2,z2);
	}
	
	// Update is called once per frame
	void Update(){
		if(deathwait == 1){
			deathwait -= Time.deltaTime;
			if(Global.death1 == true){
				Global.death1 = false;
				Global.chaiswro1 = false;
			}
			if(Global.death2 == true){
				Global.death2 = false;
				Global.chaiswro2 = false;
			}
		}
		if(playernr == 1 && Global.death1 == true){
			P1.transform.position = Spawn1;
			deathwait = 1;
		//	Instantiate(Resources.Load("dust_cloud_character_death"));
		}
		if(playernr == 2 && Global.death2 == true){
			P2.transform.position = Spawn2;
			deathwait = 1;
		//	Instantiate(Resources.Load("dust_cloud_character_death"));
		}
		if(P1.transform.position.y < -20 || P2.transform.position.y < -20){
			Global.death1 = true;
			Global.death2 = true;
		}
	}
}
