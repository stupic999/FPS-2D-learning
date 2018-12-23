using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public float bulletSpd = 10f;
    float destroyTime=2;
    float time;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time+= Time.deltaTime;
        transform.Translate(Vector3.forward * Time.deltaTime * bulletSpd, Space.Self);
        if (time >= destroyTime)
        {
            Destroy(gameObject);
        }
	}
}
