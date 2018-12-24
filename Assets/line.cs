using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line : MonoBehaviour {

    public LayerMask emy;
    float NextFire = 0.3f;
    float FireCD;

    void Update() {
        if (FireCD < NextFire)
            FireCD += Time.deltaTime;

        Debug.DrawLine(transform.position, -transform.up * 1000, Color.red);
        if (Input.GetMouseButton(0) && FireCD >= NextFire)
        {
            if (Physics2D.Raycast(transform.position, -transform.up * 10, 100, emy))
            {
                print("There is something in front of the object!");
                FireCD = 0;
            }
        }
    }
}
