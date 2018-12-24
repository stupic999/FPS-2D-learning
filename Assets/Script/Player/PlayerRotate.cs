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
        /*
            Vector2 mousePosition = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
            Vector2 direction = mousePosition - new Vector2(transform.position.x,transform.position.y);
            transform.rotation = Quaternion.LookRotation(direction);
            */
    }
}
