using UnityEngine;
using System.Collections;

//This script creates a rocket instance
public class Firing : MonoBehaviour {
    public Transform offset;
    public GameObject rocketFired;
    public float cooldownTime;
	// Use this for initialization
	public void fire()
    {
        
        Instantiate(rocketFired, offset.position, offset.rotation);
    }
}
