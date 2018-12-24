using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [System.Serializable]
    public class playerStats
    {
        public int Health = 100;
    }

    public playerStats playerStat = new playerStats();

    void FixedUpdate()
    {
        // 移动
        if (Input.GetKey(KeyCode.W))
            transform.Translate(0, 0.1f, 0, Space.World);

        if (Input.GetKey(KeyCode.S))
            transform.Translate(0, -0.1f, 0, Space.World);

        if (Input.GetKey(KeyCode.A))
            transform.Translate(-0.1f, 0, 0, Space.World);

        if (Input.GetKey(KeyCode.D))
            transform.Translate(0.1f, 0, 0, Space.World);
    }

    public void DamagePlayer(int damage)
    {
        playerStat.Health -= damage;
        if (playerStat.Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
