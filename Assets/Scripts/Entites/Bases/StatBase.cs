using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatBase : MonoBehaviour
{
    [Header("Health")]
    public int health;
    public int healthMaxium;

    protected virtual void Awake()
    {
        Init();
    }

    protected virtual void Init()
    {
        health = healthMaxium;
    }

    public virtual void Damaged(int value)
    {
        health -= value;
        health = Mathf.Clamp(health, 0, healthMaxium);

        if (health <= 0)
        {
            health = 0;
            Dead();
        }
    }

    protected virtual void Dead()
    {

    }
}
