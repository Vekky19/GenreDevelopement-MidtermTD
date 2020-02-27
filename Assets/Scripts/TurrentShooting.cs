using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurrentShooting : MonoBehaviour
{
    public bool IsPlaced;

    public float bulletCooldown = 30;
    float timer = 0;

    bool hasTarget;

    public Transform firePoint;
    public GameObject bulletPrefab;

    private void Start()
    {
        IsPlaced = false;
    }

    void FireBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.Inverse(firePoint.rotation));
        BulletScript bulletS = bullet.GetComponent<BulletScript>();
        bulletS.target = firePoint.gameObject.GetComponentInParent<TurrentTargeting>().target;
    }

    // Update is called once per frame
    void Update()
    {
        timer++;
        hasTarget = this.gameObject.GetComponent<TurrentTargeting>().hasATarget;

        if (timer >= bulletCooldown && hasTarget == true && IsPlaced == true)
        {
            FireBullet();
            timer = 0;
        }
        
    }
}
