using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed = 5.0f;
    public float rotateSpeed = 100.0f;
    public GameObject pellet = null;
    public Transform socket = null;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Move();
        Shoot();
	}
    void Move(){
        float move = Input.GetAxis("Vertical") * moveSpeed;
        float rotation = Input.GetAxis("Horizontal") * rotateSpeed;
        this.transform.Translate(0, 0, move * Time.deltaTime);
        this.transform.Rotate(0, rotation * Time.deltaTime, 0);
    }

    void Shoot(){
        if (Input.GetButtonDown("Fire1")){
            GameObject obj = Instantiate(pellet, socket.position, socket.rotation) as GameObject;
            obj.name = "pellet";
            Destroy(obj.gameObject, 2);
        }
    }
}
