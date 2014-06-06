using UnityEngine;
using System.Collections;

public class Playercollision : MonoBehaviour {
	public int count;
	void Start(){
		count = 0;
	}
	void OnTriggerEnter(Collider other) {
		if(other.tag == Tags.pickups){
			other.gameObject.SetActive(false);
			count += 1;
		}
	}
}
