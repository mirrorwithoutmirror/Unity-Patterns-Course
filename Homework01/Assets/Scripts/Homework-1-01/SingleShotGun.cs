using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleShotGun : IShooter
{
    private int _currentBullets;
    private GameObject _bulletPrefab;
    private Transform _bulletSpawnPoint;

    public SingleShotGun(GameObject bulletPrefab, Transform bulletSpawnPoint, int maxBullets)
    {
        _bulletPrefab = bulletPrefab;
        _bulletSpawnPoint = bulletSpawnPoint;
        _currentBullets = maxBullets;
        Debug.Log("Picked up Single Shot Gun!");
        Debug.Log($"I`ve got {_currentBullets} bullets.");
    }

    public void Shoot()
    {
        if (_currentBullets > 0)
        {
            GameObject.Instantiate(_bulletPrefab, _bulletSpawnPoint.position, Quaternion.identity, _bulletSpawnPoint);
            _currentBullets--;
            Debug.Log($"I`ve got {_currentBullets} bullets left.");
        }
        else
        {
            Debug.Log($"I`ve got no bullets left!");
        }
    }
}
