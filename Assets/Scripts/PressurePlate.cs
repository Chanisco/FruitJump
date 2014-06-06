using UnityEngine;
using System.Collections;

public class PressurePlate : MonoBehaviour {
	
	
	public GameObject butTop;
	public GameObject moveItem;
	
	public float maxRotate;
	public float minRotate;
	
	private int active = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(active != 0 && moveItem.transform.eulerAngles.z < maxRotate)
		{
			moveItem.transform.Rotate(new Vector3(0f,0f,5f));
		}
		if(active == 0 && moveItem.transform.eulerAngles.z > minRotate)
		{
			moveItem.transform.Rotate(new Vector3(0f,0f,-5f));
		}
	}
	
	void OnTriggerEnter(Collider col)
	{
		if(col.collider.name == "Player1" || col.collider.name == "Player2")
		{
			
			butTop.transform.Translate(new Vector3(0f,-0.3f,0f));
			
			active += 1;
		}
	}
	
	void OnTriggerExit(Collider col)
	{
		if(col.collider.name == "Player1" || col.collider.name == "Player2")
		{
			
			butTop.transform.Translate(new Vector3(0f,0.3f,0f));
			
			active -= 1;
		}
	}
}
