using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadDameToPlayer : Damedealer
{
    protected override void SendDametoObj(Transform obj)
    {
        PlayerReciver playerReciver = obj.GetComponent<PlayerReciver>();
        if(playerReciver == null) return;
        playerReciver.ReducedHp(this.Dame);
    }
}
