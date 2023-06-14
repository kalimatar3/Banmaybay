using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamedealToEnemie : Damedealer
{
    protected override void SendDametoObj(Transform obj)
    {
        EnemieReciver enemieReciver = obj.GetComponent<EnemieReciver>();
        if(enemieReciver == null) return;
        enemieReciver.ReducedHp(this.Dame);
        BulletSpawner.Instance.DeSpawnToPool(this.transform.parent);
    }
}
