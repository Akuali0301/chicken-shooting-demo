using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatherFly : AkuaMonoBehaviour
{
    [SerializeField] protected float moveSpeed;
    [SerializeField] protected Vector3 direction;


    private void Update()
    {
        transform.parent.Translate(this.direction * this.moveSpeed * Time.deltaTime);
    }
}
