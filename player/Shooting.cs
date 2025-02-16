using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] protected bool isShooting = false;
    [SerializeField] protected Transform bulletPrefab;
    [SerializeField] protected float shootDelay = 0.2f;
    [SerializeField] protected float lastShootTime = 0f;

    private void Update()
    {
        this.ClickToShoot();
    }

    protected virtual void ClickToShoot()
    {
        if (Input.GetButton("Fire1"))
        {
            float currentTime = Time.time;

            // Check delay betwen bullets
            if (currentTime - lastShootTime >= shootDelay)
            {
                lastShootTime = currentTime; // Update the last shoot time
                Shoot();
                Debug.Log("Shooting");
            }
        }
    }

    protected virtual void Shoot()
    {
        Vector3 spawnPos = transform.position;
        Quaternion rotation = new Quaternion(0, 0, 0, 0);
        Transform newBullet = BulletSpawner.Instance.Spawn(BulletSpawner.bullet1, spawnPos, rotation);
        if (newBullet == null) return;

        newBullet.gameObject.SetActive(true);
    }

}
