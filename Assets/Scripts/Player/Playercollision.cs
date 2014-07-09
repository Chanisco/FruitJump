using UnityEngine;
using System.Collections;

public class Playercollision : MonoBehaviour {
	public int count;
	void Start(){
		count = 0;
	}
	void OnTriggerEnter(Collider other) {
		if(other.collider.tag == Tags.pickups){
			Destroy(other.gameObject);
			count += 1;

		}
	}
}
