using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weopon : MonoBehaviour
{
    private IShooter _shooter;

    public void SetShootingType(IShooter shooter)
    {
        _shooter = shooter;
    }

    public void Fire()
    {
        _shooter.Shoot();
    }
}
