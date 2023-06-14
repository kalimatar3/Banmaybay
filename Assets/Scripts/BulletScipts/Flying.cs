using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MyBehaviourScript
{
    [SerializeField] protected float speed;
    protected virtual void Fly()
    {
        this.transform.parent.Translate(Vector3.up * this.speed * Time.deltaTime);
    }
    protected void FixedUpdate()
    {
        this.Fly();
    }
}
