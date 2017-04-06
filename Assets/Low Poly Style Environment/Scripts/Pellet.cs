using UnityEngine;
using System.Collections;

public class Pellet : MonoBehaviour
{
    public float speed = 5.0f;
    public Rigidbody rb;
    public Rigidbody cannon;
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
            MoveObject();
    }

    void MoveObject()
    {
        rb.GetComponent<Rigidbody>().AddForce(cannon.transform.forward * speed);
    }
    /*
    void OnTriggerEnter(Collider other)
    {
        this.GetComponent<AudioSource>().PlayOneShot(audioHit);

        this.GetComponent<Renderer>().enabled = false;
        this.GetComponent<Collider>().enabled = false;

        canMove = false;

        particle.enableEmission = false;

        Destroy(this.gameObject, audioHit.length);
    }
    */
}
















