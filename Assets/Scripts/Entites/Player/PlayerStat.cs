using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : StatBase
{
    [Header("Movement")]
    public float moveSpeed;

    [Header("Attack")]
    public int attackPower = 1;
    public int attackCount = 1;
    public float attackDelay = 2f;

    protected override void Awake()
    {
        base.Awake();
    }

    protected override void Init()
    {
        base.Init();
    }

    protected override void Dead()
    {
        base.Dead();
    }
}
