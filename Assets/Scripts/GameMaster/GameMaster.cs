using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MyBehaviourScript
{
    protected static GameMaster instance;
    public static GameMaster Instance { get => instance ;}
    public float Score;
    protected override void Awake()
    {
        base.Awake();
        if(instance != this && instance != null) Destroy(this);
        else instance = this;
    }
    public void AddScore()
    {
        this.Score ++;
    }
    protected void Win()
    {
        if(this.Score >= 16) 
        {
            Loader.Load(Loader.Scene.LastScene);
        }
    }
    protected void FixedUpdate()
    {
        this.Win();
    }
}
