using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleGun : IShooter
{
    private int _maxBullets;
    private int _currentBullets;
    private GameObject _bulletPrefab;
    private Transform _bulletSpawnPoint;

    public TripleGun(GameObject bulletPrefab, Transform bulletSpawnPoint, int maxBullets)
    {
        _bulletPrefab = bulletPrefab;
        _bulletSpawnPoint = bulletSpawnPoint;
        _currentBullets = maxBullets;
        Debug.Log("Picked up Triple Gun!");
        Debug.Log($"I`ve got {_maxBullets} bullets.");
    }

    public void Shoot()
    {
        if (_currentBullets >= 3)
        {
            for (int i = -1; i < 2; i++)
            {
                GameObject.Instantiate(_bulletPrefab, _bulletSpawnPoint.position + new Vector3(i / 2f, 0, 0), Quaternion.identity, _bulletSpawnPoint);
            }
            _currentBullets -= 3;
            Debug.Log($"I`ve got {_currentBullets} bullets left.");
        }
        else
        {
            Debug.Log($"I`ve got no bullets left!");
        }
    }
}
