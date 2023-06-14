using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damedealer : MyBehaviourScript
{
    [SerializeField] protected int Dame;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.Dame = 1;
    }
    protected virtual void SendDametoObj(Transform obj)
    {
        DameReciver dameReciver = null;
        dameReciver = obj.GetComponent<DameReciver>();
        if(dameReciver == null) return;
        this.SendDame(dameReciver);
        BulletSpawner.Instance.DeSpawnToPool(this.transform.parent);
    }
    protected virtual void SendDame(DameReciver dameReciver)
    {
        dameReciver.ReducedHp(this.Dame);
        return;
    }
  protected void OnTriggerEnter2D(Collider2D other)  
  {
    this.SendDametoObj(other.transform);
  }
}
