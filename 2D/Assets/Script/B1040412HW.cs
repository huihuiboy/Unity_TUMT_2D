using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B1040412HW : MonoBehaviour
{

    [Header("對話")]
    public string SayStart = "安安";
    public string SayNotComplete = "你還沒準備好";
    public string SayComplete = "謝大哥";
    [Header("對話速度")]
    public float Speed = 1.1f;
    [Header("任務相關")]
    public bool Complete = false;
    public int CountPlayer = 0;
    public int CountFinish = 10;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}