using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	
	
	public float moveSpeed;
	public int playerNum;
	private int canjump;
	
	public AudioClip jumpSound;
	public Animator animator;

	void Awake(){
		animator = GetComponent<Animator>();
	}
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
			animator.SetBool("Run",true);
			Vector3 movement = new Vector3(x * moveSpeed, 0f, 0f);
			transform.Translate(movement);
		}
		else
		{
			animator.SetBool("Run",false);
		}
		if(canjump == 1 & jump != 0)
		{
			rigidbody.AddForce(new Vector3(0,3000 * jump,0));
			canjump = 0;

			animator.SetBool("Run",true);
			AudioSource.PlayClipAtPoint(jumpSound,transform.position, 0.5f);
		}
		else
		{
			animator.SetBool("Run",false);
		}
	}
	void OnCollisionEnter(Collision other) {
		if(other.collider.tag == Tags.platform){
			canjump = 1;
		}
	}
	/*void OnCollisionStay()
	{
		canjump = 1;
	}
	 */
	void OnCollisionExit()
	{
		if(playerNum == 1)
			{
				Global.ChangeIsWrong1 = false;
			}
			else
			{
				Global.ChangeIsWrong2 = false;
			}
	}
}
