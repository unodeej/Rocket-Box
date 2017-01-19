using UnityEngine;
using System.Collections;

public class Firing : MonoBehaviour {
    public Transform offset;
    public GameObject rocketFired;
	// Use this for initialization
	void fire()
    {
        Instantiate(rocketFired, offset.position, offset.rotation);
    }
}
