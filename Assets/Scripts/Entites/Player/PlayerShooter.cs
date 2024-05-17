using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    [SerializeField] private PlayerBullet bulletPrefab; //Temp
    [SerializeField] private Transform bulletPoint;
    [SerializeField] private int bulletMaxium;
    public void Shoot(int count, int damage)
    {
        count = Mathf.Clamp(count, 1, bulletMaxium);
        bulletPrefab.damage = damage;

        for (int index = 0; index < count; index++)
            Instantiate(bulletPrefab, bulletPoint.position, Quaternion.identity);
    }
}
