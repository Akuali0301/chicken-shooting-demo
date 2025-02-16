using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnByDistance : Despawn
{
    [SerializeField] protected float distanceLimit = 20f;
    [SerializeField] protected float distance = 0f;
    [SerializeField] protected Camera mainCam;


    protected override void FixedUpdate()
    {
        this.Despawning();
    }


    protected override bool CanDespawn()
    {
        this.distance = Vector3.Distance(transform.position, this.mainCam.transform.position);
        if (this.distance > distanceLimit) return true;
        return false;
    }

    protected override void Despawning()
    {
        if (!this.CanDespawn()) return;
        this.DespawnObject();
    }



    protected override void LoadComponents()
    {
        this.LoadCamera();
    }

    protected virtual void LoadCamera()
    {
        if (this.mainCam != null) return;
        this.mainCam = Transform.FindObjectOfType<Camera>();
        Debug.Log(transform.parent.name + ": Load Camera", gameObject);
    }


}
