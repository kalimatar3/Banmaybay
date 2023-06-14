using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Createmap : MyBehaviourScript
{
    [SerializeField] protected Vector3 test;
    [SerializeField] protected GameObject Enemieprefab;
    [SerializeField]protected float Timer;
    protected GameObject[] Enemies;
    [SerializeField] protected Vector3[,] EMleft,EMright ;
    protected Vector3 [] EMmid;
    protected override void LoadComponents()
    {
        base.LoadComponents();
        EMright = new Vector3 [10,10];
        EMleft = new Vector3 [10,10];
        EMmid = new Vector3[6];
        this.Enemies = new GameObject[20];
    }
    protected override void Start()
    {
    base.Start();
    this.test = Camera.main.ScreenToWorldPoint(Vector3.zero);
    this.CreatMaxtrix();
    this.CreatEnemeis();
   }
   protected void CreatEnemeis()
   {
    for(int i = 0;  i < 8; i++)
    {
    this.Enemies[i] =  Instantiate(Enemieprefab,test + new Vector3(0,9,1),Quaternion.identity);
    this.Enemies[i+8] = Instantiate(Enemieprefab,test + new Vector3(29,9,1),Quaternion.identity);
    }
   }
   protected void CreatMaxtrix()
   {
    for(int i = 1 ; i <= 5; i++)
    {
        for(int j = 1 ; j <= 4 ; j ++)
        {
        this.EMleft[i,j] = test +  new Vector3(j * 29f/9f,i * 9f/6f + 9,1);
        }
        for(int j = 8 ; j >=5; j--)
        {
        this.EMright[i,9-j] =  test + new Vector3(j * 29f/9f , i * 9f/6f + 9,1);
        }
        this.EMmid[i] = test + new Vector3(4 * 29f/9f + 29f/18f,i * 9f/6f + 9,1);
    }
    }
    protected void FixedUpdate()
    {
    Timer += Time.deltaTime *1f;
    if(Timer <= 5 && Timer > 0) this.SetupSquare();
    else if(Timer <= 10 && Timer >5) this.SetupRhombus();
    else if(Timer <= 15 && Timer > 10)  this.SetupTriangle();
    else if(Timer <= 20 && Timer >15) this.Setuprectangle();
    else Timer = 0;
    }
    protected void SetupSquare()
    {
        int k = 0;
        for(int i = 1 ;i <= 5; i++)
        {
            for (int j = 1; j <= 4 ;j ++)
            {
                if(j > 2 && i > 1)
                {
                if(this.Enemies[k] != null )  this.Enemies[k].transform.position = Vector3.Lerp(this.Enemies[k].transform.position,EMleft[i,j],Time.deltaTime * 1f);
                if(this.Enemies[k+ 8] != null) this.Enemies[k+ 8].transform.position = Vector3.Lerp(this.Enemies[k + 8].transform.position,EMright[i,j], Time.deltaTime * 1f);
                k++;
                }
            }
        }
    }
    protected void SetupRhombus()
    {
    int k = 0;
    for(int i = 1 ;i <= 5; i++)
    {
        for (int j = 1; j <= 4 ;j ++)
        {
            if(j > 2 && i > 1 && i < 5)
            {                   
            if(this.Enemies[k] != null ) this.Enemies[k].transform.position = Vector3.Lerp(this.Enemies[k].transform.position,EMleft[i,j],Time.deltaTime * 1f);
            if(this.Enemies[k+ 8] != null) this.Enemies[k+ 8].transform.position = Vector3.Lerp(this.Enemies[k + 8].transform.position,EMright[i,j], Time.deltaTime * 1f);
            k++;
            }
            else if(i == 3 && j == 2 )
            {
            if(this.Enemies[k] != null )  this.Enemies[k].transform.position = Vector3.Lerp(this.Enemies[k].transform.position,EMleft[i,j],Time.deltaTime * 1f);
            if(this.Enemies[k+ 8] != null) this.Enemies[k+ 8].transform.position = Vector3.Lerp(this.Enemies[k + 8].transform.position,EMright[i,j], Time.deltaTime * 1f);
            k++;
            }
        }
    }               
    if(this.Enemies[7] != null ) this.Enemies[7].transform.position = Vector3.Lerp(this.Enemies[7].transform.position,EMmid[1],Time.deltaTime * 1f);
    if(this.Enemies[15] != null ) this.Enemies[15].transform.position = Vector3.Lerp(this.Enemies[15].transform.position,EMmid[5],Time.deltaTime * 1f);
    }
    protected void SetupTriangle()
    {
    int k = 0;
    for(int i = 1 ;i <= 5; i++)
    {
        for (int j = 1; j <= 4 ;j ++)
        {
            if( i == 1 ||  i == j)
            {             
            if(this.Enemies[k] != null )  this.Enemies[k].transform.position = Vector3.Lerp(this.Enemies[k].transform.position,EMleft[i,j],Time.deltaTime * 1f);
            if(this.Enemies[k+ 8] != null) this.Enemies[k+ 8].transform.position = Vector3.Lerp(this.Enemies[k + 8].transform.position,EMright[i,j], Time.deltaTime * 1f);
            k++;
           }
        } 
    }
    if(this.Enemies[7] != null ) this.Enemies[7].transform.position = Vector3.Lerp(this.Enemies[7].transform.position,EMmid[1],Time.deltaTime * 1f);
    if(this.Enemies[15] != null ) this.Enemies[15].transform.position = Vector3.Lerp(this.Enemies[15].transform.position,EMmid[5],Time.deltaTime * 1f);
    }
    protected void Setuprectangle()
    {
    int k = 0;
    for(int i = 1 ;i <= 5; i++)
    {
        for (int j = 1; j <= 4 ;j ++)
        {
            if( i == 2 && j > 1||  i == 4 && j > 1)
            {             
            if(this.Enemies[k] != null )  this.Enemies[k].transform.position = Vector3.Lerp(this.Enemies[k].transform.position,EMleft[i,j],Time.deltaTime * 1f);
            if(this.Enemies[k+ 8] != null) this.Enemies[k+ 8].transform.position = Vector3.Lerp(this.Enemies[k + 8].transform.position,EMright[i,j], Time.deltaTime * 1f);
            k++;
           }
        } 
    }
    if(this.Enemies[6] != null ) this.Enemies[6].transform.position = Vector3.Lerp(this.Enemies[6].transform.position,EMleft[3,2],Time.deltaTime * 1f);
    if(this.Enemies[14] != null ) this.Enemies[14].transform.position = Vector3.Lerp(this.Enemies[14].transform.position,EMright[3,2],Time.deltaTime * 1f);
    if(this.Enemies[7] != null ) this.Enemies[7].transform.position = Vector3.Lerp(this.Enemies[7].transform.position,EMmid[2],Time.deltaTime * 1f);
    if(this.Enemies[15] != null ) this.Enemies[15].transform.position = Vector3.Lerp(this.Enemies[15].transform.position,EMmid[4],Time.deltaTime * 1f);

    }
}
