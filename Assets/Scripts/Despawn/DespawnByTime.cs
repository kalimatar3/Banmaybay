using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnByTime : Despawn
{
     protected float Timer;
    [SerializeField] protected float DespawnTime;
    protected override void FixedUpdate()
    {
        base.FixedUpdate();
        Timer += Time.deltaTime * 1f;
    }
    protected override bool CanDeSpawn()
    {
        if(Timer >= DespawnTime ) 
        {
            Timer = 0;
            return true;
        }
        else return false;
    }
    protected override void DeSpawnObjects()
    {
    BulletSpawner.Instance.DeSpawnToPool(this.transform.parent);
    }
}
