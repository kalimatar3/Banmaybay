using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotting : MyBehaviourScript
{
    [SerializeField] protected float FireRate;
    [SerializeField] protected Transform Guntip;
    protected float FireTime;
    protected virtual void Shot()
    {
        FireTime += Time.deltaTime *1f;
        if(FireTime >= FireRate)
        {
            FireTime = 0;
            BulletSpawner.Instance.Spawn("Bullet1",this.Guntip.position,this.Guntip.rotation);
        }
    }
    protected void FixedUpdate()
    {
        this.Shot();
    }
}
