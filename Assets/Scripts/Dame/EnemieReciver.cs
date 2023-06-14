using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieReciver : DameReciver
{
    protected override void Dead(bool CanDead)
    {
        base.Dead(CanDead);
        if(CanDead) 
        {
        Destroy(transform.parent.gameObject);
        GameMaster.Instance.AddScore();
        }
    }
}
