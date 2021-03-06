﻿using UnityEngine;

/// <summary>
/// Fires given bullet prefab at the specified bulletSpeed.
/// </summary>
public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;

    public int bulletSpeed;

    public void FireBullet(Vector3 position, Vector3 direction, string ownerId)
    {
        GameObject bullet = Instantiate(bulletPrefab) as GameObject;

        Bullet b = bullet.GetComponent<Bullet>();
        b.ownerId = ownerId;

        bullet.transform.position = position;
        bullet.GetComponent<Rigidbody>().velocity = direction * bulletSpeed;
    }
}
