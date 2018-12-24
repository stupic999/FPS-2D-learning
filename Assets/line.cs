using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line : MonoBehaviour {

    public LayerMask emy;

    void Update() {

        Debug.DrawLine(transform.position, -transform.up * 1000, Color.red);

        if (Physics2D.Raycast(transform.position, -transform.up * 10, 100,emy))
            print("There is something in front of the object!");
    }
}
