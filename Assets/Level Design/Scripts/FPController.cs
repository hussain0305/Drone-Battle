using UnityEngine;
using System.Collections;

public class FPController : MonoBehaviour {

    public float Speed;
    GameObject FPParent;
    // Use this for initialization
    void Start () {
        FPParent = new GameObject("FPParent");
        UpdateParent();
        Input.gyro.enabled = true;
    }
	
	// Update is called once per frame
	void Update () {
        //UpdateParent();
        FPParent.transform.Rotate(0, -Input.gyro.rotationRateUnbiased.y, 0);
        this.transform.Rotate(-Input.gyro.rotationRateUnbiased.x, 0, 0);
        if (Input.GetButtonDown("Fire1"))
        {
            this.transform.Translate( 0, 0, 10 * Time.deltaTime);
        }
    }
    void UpdateParent()
    {
        FPParent.transform.position = this.transform.position;
        this.transform.parent = FPParent.transform;
    }
}
