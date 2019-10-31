using System.Collections;
using System.Collections.Generic;
using UnityEngine;  //引用Unity API(倉庫、功能、工具)


public class fox : MonoBehaviour{  //類別 類別名稱
                                   //成員：欄位、屬性、方法、事件
                                   //事件：在特定的時間點會以指定的頻率執行的方法

    public int Speed = 200;
    public float jump = 1000f;
    public string  foxName = "foxy" ;
    public bool pass = false;
    public bool isGround;

    private Rigidbody2D foxyee;
    //private Transform tra;  原始寫法

    private void Start() //開始事件：遊戲開始時執行一次
    {
        foxyee = GetComponent<Rigidbody2D>();
        //tra = GetComponent<Transform>();
    }
    private void Update()
    {
        //if (Input.GetKey(KeyCode.D)) tra.eulerAngles = new Vector3(0, 0, 0);
        //if (Input.GetKey(KeyCode.A)) tra.eulerAngles = new Vector3(0, 180, 0);
        if (Input.GetKey(KeyCode.D)) Turn(0);
        if (Input.GetKey(KeyCode.A)) Turn(180);
    }
    //固定事件更新
    private void FixedUpdate()
    {
        Walk();
        Jump();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGround = true;
    }

    //方法
    private void Walk()
    {
        foxyee.AddForce(new Vector2(Speed * Input.GetAxis("Horizontal"), 0));
    }

    private void Jump()
    {
        if (Input.GetKey(KeyCode.W) && isGround == true)
        {
            isGround = false;
            foxyee.AddForce(new Vector2(0,jump));

        }
    }
    /// <summary>
    /// 轉彎
    /// </summary>
    /// <param name="diretion" >方向 ; 左轉180，右轉0 </param>
    private void Turn(int diretion)
    {
        transform.eulerAngles = new Vector3(0, diretion, 0);
    }
    
}
