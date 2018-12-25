using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public float bulletSpd = 1f;
    float destroyTime=200;
    float surviveTime;
    public int damage = 10;

    void Update () {
        surviveTime += Time.deltaTime;

        transform.Translate(-Vector2.up * Time.deltaTime * bulletSpd, Space.Self);

        if (surviveTime >= destroyTime)
        {
            Destroy(gameObject);
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Player")
            Destroy(gameObject);
        MonsterController emy = collision.GetComponent<MonsterController>();
        if (emy != null)
        {
            emy.DamageEmy(damage);
        }
    }
}
