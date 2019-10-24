using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OecThirHW : MonoBehaviour {

    [Header("對話")]
    public string SayStart = "我誰~呱呱";
    public string SayNotComplete = "你還太弱了呱呱";
    public string SayComplete = "我瘋子~呱呱";
    [Header("對話速度")]
    public float Speed = 2.5f;
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
