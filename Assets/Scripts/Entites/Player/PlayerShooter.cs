using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    public int bulletCount;

    [SerializeField] private GameObject bulletPrefab; //Temp
    [SerializeField] private Transform bulletPoint;
    [SerializeField] private int bulletMaxium;
    public void Shoot()
    {
        bulletCount = Mathf.Clamp(bulletCount, 1, bulletMaxium);

        for (int index = 0; index < bulletCount; index++)
            Instantiate(bulletPrefab, bulletPoint.position, Quaternion.identity);
    }
}
