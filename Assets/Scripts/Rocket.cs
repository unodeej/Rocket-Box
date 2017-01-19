using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {

    public float Speed;
    public GameObject impact;

    // Update is called once per frame
    void Update()
    {
        transform.position=transform.position + transform.forward * Time.deltaTime * Speed;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject != gameObject)
        {
            Instantiate(impact, other.contacts[0].point, Quaternion.identity);
        }
    }
}
