using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour {

    public float rotOffset = 90;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        Vector3 dif = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        dif.Normalize();

        float rotZ = Mathf.Atan2(dif.y, dif.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + rotOffset);
    }
}
