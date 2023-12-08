using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlimitedGun : IShooter
{
    private GameObject _bulletPrefab;
    private Transform _bulletSpawnPoint;

    public UnlimitedGun(GameObject bulletPrefab, Transform bulletSpawnPoint)
    {
        _bulletPrefab = bulletPrefab;
        _bulletSpawnPoint = bulletSpawnPoint;
        Debug.Log("Picked up Unlimited Gun!");
        Debug.Log($"I`ve got unlimited bullets!!!");
    }

    public void Shoot()
    {
        GameObject.Instantiate(_bulletPrefab, _bulletSpawnPoint.position, Quaternion.identity, _bulletSpawnPoint);
    }
}
