using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBase : MonoBehaviour
{
    public int damage;

    protected virtual void FixedUpdate()
    {

    }

    protected virtual void Destroy()
    {
        Destroy(this.gameObject); //Temp
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        other.GetComponent<StatBase>()?.Damaged(damage);
        Destroy();
    }
}
