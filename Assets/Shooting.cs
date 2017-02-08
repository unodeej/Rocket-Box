using UnityEngine;
using System.Collections;

//This script is to control the timing of rockets fired
public class Shooting : MonoBehaviour {

    public float fireRate = .5F;
    private float nextFire = 0.0F;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0)&&Time.time>nextFire)
        {
            nextFire = Time.time + fireRate;
            gameObject.GetComponent<Firing>().fire();
        }
	}
}
