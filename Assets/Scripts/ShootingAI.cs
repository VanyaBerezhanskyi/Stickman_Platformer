using System.Collections;
using UnityEngine;

public class ShootingAI : MonoBehaviour
{
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject bulletPrefab;

    public float fireRate = 0.5f;

    private float nextFire = 0.0f;

    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(firePoint.position, firePoint.right);
        if (hit)
        {
            if (hit.transform.tag == "Player" && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            }
        }
    }
}
