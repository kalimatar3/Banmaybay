using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    [SerializeField] protected Vector3 worldPosition;
    [SerializeField] protected float Speed;
    protected void FixedUpdate()
    {
        this.FollowMouse();
    }
    protected void FollowMouse()
    {
        this.worldPosition  = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.worldPosition.z = 0;
        Vector3 newPos = Vector3.Lerp(this.transform.parent.position,worldPosition,this.Speed);
        this.transform.parent.position = newPos;
    }
}
