using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class frog1 : MonoBehaviour {

    #region 欄位
    //列舉
    public enum state
    {
        Start, NotComplete, Complete
    }

    public state _state;

    [Header("對話")]
    public string SayStart = "安安，我要來點Get High的";
    public string SayNotComplete = "還不夠HIGH";
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

    public AudioClip soundSay;

    private AudioSource aud;

    private void Start()
    {
        aud = GetComponent<AudioSource>();
    }

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

        switch (_state)
        {
            case state.Start:
                StartCoroutine(ShowDialog(SayStart));
                _state = state.NotComplete;
                break;
            case state.Complete:
                StartCoroutine(ShowDialog(SayComplete));
                
                break;
            case state.NotComplete:
                if (CountPlayer == CountFinish)
                {
                    Complete = true;
                    _state = state.Complete; }
                else { StartCoroutine(ShowDialog(SayNotComplete)); }
                break;
        }
    }
    private IEnumerator ShowDialog(string say)
    {
        textSay.text = "";                              // 清空文字

        for (int i = 0; i < say.Length; i++)            // 迴圈跑對話.長度
        {
            textSay.text += say[i].ToString();         // 累加每個文字
            aud.PlayOneShot(soundSay, 0.6f);           // 播放一次音效(音效片段，音量)
            yield return new WaitForSeconds(Speed);    // 等待
        }
    }
    /// <summary>
    /// 關閉對話
    /// </summary>
    private void SayClose()
        {
            StopAllCoroutines();
            gObject.SetActive(false);
        }
    /// <summary>
    /// 玩家取得道具
    /// </summary>
    public void PlayerGet()
    {
        CountPlayer++;
    }
}
