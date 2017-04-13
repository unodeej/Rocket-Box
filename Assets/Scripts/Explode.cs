using UnityEngine;
using System.Collections;

public class Explode : MonoBehaviour {

	//TODO: explosion model for game
	void ExplosionDamage(Vector3 center, float radius) {
		Collider[] hitColliders = Physics.OverlapSphere(center, radius);
		int i = 0;
		while (i < hitColliders.Length) {
			if(hitColliders[i].CompareTag("Player")){
				//check if player, apply damage if so
				hitColliders[i].gameObject.GetComponent<Character>().TakeDamage();
				//needs PlayerScript w/ AddDamage() implmented to work, yell at Tiffany
				Debug.Log("player take damage");
				break;
			}
			i++;
		}
	}

	// Use this for initialization
	void Start () {
		ExplosionDamage (transform.position, 2F);
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
