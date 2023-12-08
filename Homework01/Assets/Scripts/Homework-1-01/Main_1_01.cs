using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_1_01 : MonoBehaviour
{
    [SerializeField] private Weopon _weopon;
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform _bulletSpawnPoint;

    private void Awake()
    {
        Debug.Log("Press 1 to choose Single Shot Gun");
        Debug.Log("Press 2 to choose Unlimited Gun");
        Debug.Log("Press 2 to choose Triple Shot Gun\n");

        _weopon.SetShootingType(new SingleShotGun(_bulletPrefab, _bulletSpawnPoint, 10));
    }

    private void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            _weopon.SetShootingType(new SingleShotGun(_bulletPrefab, _bulletSpawnPoint, 10));
        }

        if (Input.GetKeyDown("2"))
        {
            _weopon.SetShootingType(new UnlimitedGun(_bulletPrefab, _bulletSpawnPoint));
        }

        if (Input.GetKeyDown("3"))
        {
            _weopon.SetShootingType(new TripleGun(_bulletPrefab, _bulletSpawnPoint, 30));
        }

        if (Input.GetKeyDown("space"))
        {
            _weopon.Fire();
        }
    }
}
