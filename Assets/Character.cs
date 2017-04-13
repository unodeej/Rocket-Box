using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

	public int hp = 50;
	private int invincible = 0; //how long the character is invincible for

	// Use this for initialization
	void Start () {
		hp = 50;
		Debug.Log("start");
	}

	// Update is called once per frame
	void Update () {
		if(hp <= 0){
			Debug.Log ("Character is dead");
		}
		//does FPS have transform? move character back by a litle
	}

	void OnControllerColliderHit(ControllerColliderHit other)
	{
		if (other.gameObject.CompareTag(Tags.Rocket))
		{
			//add code when we have other types of rockets
			Debug.Log("Collision");
			//hp -= 2;
			TakeDamage();
		}
		if (other.gameObject.CompareTag(Tags.Spikes))
		{
			//hp--;
			invincible = 1;
			TakeDamage();
		}
	}

	public void TakeDamage()
	{
		hp-=10;
		Debug.Log ("current hp: " + hp);
	}
}