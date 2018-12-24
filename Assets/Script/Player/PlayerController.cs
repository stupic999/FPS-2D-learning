using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public GameObject bullet;
    public Transform gun;
    float NextFire = 0.3f;
    float FireCD;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(FireCD<NextFire)
        FireCD += Time.deltaTime;

        // 移动
        if (Input.GetKey(KeyCode.W))
            transform.Translate(0, 0.1f, 0, Space.World);

        if (Input.GetKey(KeyCode.S))
            transform.Translate(0, -0.1f, 0, Space.World);

        if (Input.GetKey(KeyCode.A))
            transform.Translate(-0.1f, 0, 0, Space.World);

        if (Input.GetKey(KeyCode.D))
            transform.Translate(0.1f, 0, 0, Space.World);
        /*
        if (Input.GetMouseButton(0) && FireCD >= NextFire)
        {
            Instantiate(bullet, new Vector3(gun.position.x, gun.position.y, 0), gun.rotation);
            FireCD = 0;
        }
        */
    }
}
