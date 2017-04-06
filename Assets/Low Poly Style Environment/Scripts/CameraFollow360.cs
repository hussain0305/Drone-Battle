using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow360 : MonoBehaviour {

	public Transform player;
	public float distance = 5;
	public Vector3 lookOffset = new Vector3(0,1,0);
	public float cameraSpeed = 8;

	void Update () 
	{
		Vector3 lookPosition = player.position + lookOffset;
		this.transform.LookAt(lookPosition);
		
		float distToPlayer = Vector3.Distance(this.transform.position,lookPosition);

		if(distToPlayer > distance)
		{
			this.transform.Translate(0,0,cameraSpeed * Time.deltaTime);
		}
	}
}
