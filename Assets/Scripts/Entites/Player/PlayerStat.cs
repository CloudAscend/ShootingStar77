using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;

    [Header("Health")]
    public int health;
    public int healthMaxium;

    [Header("Attack")]
    public int attackPower;
    public int attackDelay;
    public int attackCount;

    public void Damaged(int value)
    {
        health -= value;
        health = Mathf.Clamp(health, 0, healthMaxium);

        if (health <= 0)
        {
            health = 0;
            Dead();
        }
    }

    private void Dead()
    {

    }
}
