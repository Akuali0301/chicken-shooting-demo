using UnityEngine;

public class JunkFly : FatherFly
{
    protected override void ResetValue()
    {
        base.ResetValue();
        this.moveSpeed = 0.5f;
        this.direction = Vector3.down ;
    }

}
