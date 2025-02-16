using UnityEngine;

public class BulletFly : FatherFly
{
    protected override void ResetValue()
    {
        base.ResetValue();
        this.moveSpeed = 15f;
        this.direction = Vector3.up;
    }

}
