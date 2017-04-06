using UnityEngine;
using System.Collections;

public class QuaternionTestScript : MonoBehaviour {

    //private Quaternion cubeBase = Quaternion.identity;
    //private int c = 1;
    // Use this for initialization
    private float lastAngle = 0.0f;
    private float angleDiff;
    GameObject cam;
    GyroController gc;

    void Start () {
        cam = GameObject.Find("Main Camera");
        gc = cam.GetComponent<GyroController>();
    }
	
	// Update is called once per frame
	void Update () {
      
    }
    public void Rotate(float angle)
    {
        angleDiff = angle - lastAngle;
        if (angle > lastAngle)
            this.transform.Rotate(0, angle, 0);
        else
            this.transform.Rotate(0, -angle, 0);
        lastAngle = angle;
        //Debug.Log(angle);
        //Debug.Log("Updated" + Quaternion.identity);
        gc.cameraBase = Quaternion.identity;
        gc.calibration = Quaternion.identity;
        gc.baseOrientationRotationFix = Quaternion.identity;
        gc.referanceRotation = Quaternion.identity;
        gc.baseOrientation = Quaternion.Euler(90, 0, 0);


    }
}
