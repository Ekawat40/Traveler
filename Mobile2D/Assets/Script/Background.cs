using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {
    public float bgSpeed;
    float bgPositionX;
    float bgPositionX1;

	// Use this for initialization
	void Start () {
        bgPositionX = transform.position.x;
        bgPositionX1 = GameObject.Find("Background").transform.position.x;

	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x + bgSpeed, transform.position.y, transform.position.z);
        if(transform.position.x < (bgPositionX1 * -1.25f))
        {
            transform.position = new Vector3 (bgPositionX1, transform.position.y, transform.position.z);
        }
       
	}
}
