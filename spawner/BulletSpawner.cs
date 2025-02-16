using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : Spawner
{
    private static BulletSpawner instance;
    public static BulletSpawner Instance { get => instance; }


    public static string bullet1 = "RedBullet";


    protected override void Awake() //Singleton for BulletSpawner
    {
        base.Awake();
        if (BulletSpawner.instance != null) Debug.LogError("Only 1 BulletSpawner allow");
        BulletSpawner.instance = this;
    }
}
