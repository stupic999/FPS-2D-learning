using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line : MonoBehaviour {

    public GameObject bullet;
    public Transform gun;
    public LayerMask emy;
    public int damage=10;
    float NextFire = 0.3f;
    float FireCD;

    void Update() {
        if (FireCD < NextFire)
            FireCD += Time.deltaTime;

        Debug.DrawLine(transform.position, -transform.up * 1000, Color.red);
        if (Input.GetMouseButton(0) && FireCD >= NextFire)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, -transform.up * 10, 100, emy);

                /*
                Instantiate(bullet, new Vector3(gun.position.x, gun.position.y, 0), gun.rotation);
                */
                FireCD = 0;

            if (hit.collider != null)
            {
                MonsterController emy = hit.collider.GetComponent<MonsterController>();
                if (emy != null)
                {
                    emy.DamageEmy(damage);
                    Debug.Log("we hit " + hit.collider.name + " and did " + damage + " damage.");
                }
            }
        }
    }
}
