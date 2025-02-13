using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    [SerializeField] protected Vector3 worldPosition;
    [SerializeField] protected float speed = 0.1f;

    void FixedUpdate()
    {
        this.worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.worldPosition.z = 0;

        Vector3 newPos = Vector3.Lerp(transform.parent.position, worldPosition, this.speed);
        transform.parent.position = newPos;
    }
}