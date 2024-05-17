using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : BulletBase
{
    [SerializeField] private float shotSpeed;
    protected override void FixedUpdate()
    {
        transform.Translate(shotSpeed * Time.deltaTime * Vector2.up);
    }

    protected override void Destroy()
    {
        base.Destroy();
    }
}
