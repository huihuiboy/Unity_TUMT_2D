using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class B1040412HW : MonoBehaviour
{
    #region 欄位
    //列舉
    public enum state
    {
        Normal, NotComplete, Complete
    }

    public state _state;

    [Header("對話")]
    public string SayStart = "安安，我要來點Get High的";
    public string SayNotComplete = "你還沒準備好";
    public string SayComplete = "謝大哥";
    [Header("對話速度")]
    public float Speed = 1.1f;
    [Header("任務相關")]
    public bool Complete = false;
    public int CountPlayer = 0;
    public int CountFinish = 10;
    public Text textSay;
    public GameObject gObject;
    #endregion

    // Use this for initialization

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "狐狸")
            Say();
        }
    private void OnTriggerExit2D(Collider2D collision)
        {
        if (collision.name == "狐狸")
            SayClose();
        }

    /// <summary>
    /// 對話:打字效果
    /// </summary>
    private void Say()
    {
            gObject.SetActive(true);
            textSay.text = SayStart;
    }
    /// <summary>
    /// 關閉對話
    /// </summary>
    private void SayClose()
    {
            gObject.SetActive(false);
    }
}