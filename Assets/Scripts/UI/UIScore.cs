using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIScore : MyBehaviourScript
{
    protected TextMeshProUGUI text;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.text = GetComponent<TextMeshProUGUI>();
    }
    protected void PerformScore()
    {
        this.text.SetText(GameMaster.Instance.Score.ToString());
    }
    protected void FixedUpdate()
    {
        this.PerformScore();
    }
}
