using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public float bulletSpd = 300f;
    float destroyTime=200;
    float time;
    public GameObject mon;

    public Rigidbody2D bullet;

    void Start()
    {
        bullet.GetComponent<Rigidbody2D>();
    }

    void Update () {
        time+= Time.deltaTime;
        /*
        transform.position = Vector2.MoveTowards(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), Time.deltaTime * bulletSpd);
        */
        bullet.velocity=(transform.forward*bulletSpd);

        if (transform.position == mon.transform.position)
        {
            Debug.Log("wtf");
        }

        if (time >= destroyTime)
        {
            Destroy(gameObject);
        }
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log(12);
    }
}
