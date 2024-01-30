using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    //Variables
    public Bullet bullet;
    public Transform firePoint;

    public float damage = 1;
    public float shotsPerSecond;
    float nextShotTime;

    //Firing weapon
    public void Shoot()
    {
        //Checking weapon fire rate
        if (nextShotTime <= Time.time)
        {

            //Fire bullet
            Bullet _bullet = Instantiate(bullet, firePoint.position, firePoint.rotation);
            _bullet.damage = damage;

            //Load next bullet
            nextShotTime = Time.time + (1 / shotsPerSecond);
        }

    }
}
