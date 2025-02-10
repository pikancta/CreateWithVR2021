using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject Projectile;
    public GameObject spawnPoint;
    public TvCanvascontroll tvControll;

    public void Shoot()
    {
        Instantiate(Projectile, spawnPoint.transform.position, spawnPoint.transform.rotation);
        tvControll.AddToscore();
    }
}
