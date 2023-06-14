using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class DameReciver : MyBehaviourScript
{
    [SerializeField] protected float maxHp;
    [SerializeField] protected float currentHp;
    protected virtual void FixedUpdate()
    {
    this.Dead(CanDead());
    }
    public float MaxHp => maxHp;
     public float CurrentHp => currentHp;

    public virtual void ReducedHp(float Dame)
    {
        currentHp -= Dame;
        if(currentHp <= 0 ) currentHp = 0;
    }
    public virtual void Reborn()
    {
        currentHp = maxHp;
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.Reborn();
    }
    protected virtual void Dead (bool CanDead)
    {
        //override
    }
    protected bool CanDead()
    {
        if(currentHp > 0) return false;
        else return true;
    }
}
