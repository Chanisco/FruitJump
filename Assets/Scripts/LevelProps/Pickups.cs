using UnityEngine;
using System.Collections;

public class Pickups : MonoBehaviour {
	public static int maxCollectables;
	// Use this for initialization
	void Start () {
		GameObject[] collectables = GameObject.FindGameObjectsWithTag(Tags.pickups);
		maxCollectables = collectables.Length;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
