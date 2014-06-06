using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	
	
	public float moveSpeed;
	public int playerNum;
	private int canjump;
	
	public AudioClip jumpSound;
	
	
	// Update is called once per frame
	void FixedUpdate () {
		
		float x;
		float jump;
		
		if(playerNum == 1)
		{
			x = Input.GetAxis("Player1H");
			jump = Input.GetAxis("Jump1");
		}
		else
		{
			x = Input.GetAxis("Player2H");
			jump = Input.GetAxis("Jump2");
		}
		if(x != 0)
		{
			Vector3 movement = new Vector3(x * moveSpeed, 0f, 0f);
			transform.Translate(movement);
			
			
		}
		if(canjump == 1 & jump != 0)
		{
			rigidbody.AddForce(new Vector3(0,1500 * jump,0));
			canjump = 0;
			
			AudioSource.PlayClipAtPoint(jumpSound,transform.position, 0.5f);
		}
	}
	void OnCollisionStay()
	{
		canjump = 1;
	}
	void OnCollisionExit()
	{
		if(playerNum == 1)
			{
				Global.chaiswro1 = false;
			}
			else
			{
				Global.chaiswro2 = false;
			}
	}
}
