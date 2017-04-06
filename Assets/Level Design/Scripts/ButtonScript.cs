using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {

    public GameObject player;
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void onClick()
    {

        player.transform.Translate(0, 0, 100 * Time.deltaTime);
        
            
        
    }
    
}
