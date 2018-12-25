using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject bullet;
    public Transform gun;
    public LayerMask emy;
    
    float NextFire = 0.3f;
    float FireCD;

    void Update() {
        if (FireCD < NextFire)
            FireCD += Time.deltaTime;

       // Debug.DrawLine(transform.position, -transform.up * 1000, Color.red);
        if (Input.GetMouseButton(0) && FireCD >= NextFire)
        {
          //  RaycastHit2D hit = Physics2D.Raycast(transform.position, -transform.up * 10, 100, emy);
            Effect();
            FireCD = 0;
        }
    }

    public void Effect()
    {
        Instantiate(bullet, gun.position, gun.rotation);
    }
}
