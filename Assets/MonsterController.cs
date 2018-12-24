using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    [System.Serializable]
    public class monsterStats
    {
        public int Health=100;
    }

    public monsterStats emyStats=new monsterStats();

    public void DamageEmy(int damage)
    {
        emyStats.Health -= damage;
        if (emyStats.Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
