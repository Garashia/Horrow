using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextWriter : MonoBehaviour
{
    [SerializeField]
    private DestroyFlag playerFlag;
    [SerializeField]
    private UIText uitext;
    [SerializeField]
    private string[] message;
    [SerializeField]
    private GameObject panel;

    private bool messageFlag;
    // Start is called before the first frame update
    void Start()
    {
        messageFlag = false;
        panel.SetActive(false);
    }

    public void RenderMessage()
    {
        panel.SetActive(true);

        StartCoroutine(Cotest());
    }
    // クリック待ちのコルーチン
    IEnumerator Skip()
    {
        while (uitext.playing) yield return 0;
        while (!uitext.IsClicked()) yield return 0;
    }

    // 文章を表示させるコルーチン
    IEnumerator Cotest()
    {
        playerFlag.SetDestroyFlag(true);
        for (int i = 0; i < message.Length; i++)
        {
            uitext.DrawText(message[i]);
            yield return StartCoroutine(Skip());
        }

        //uitext.DrawText("名前", "人が話すのならこんな感じ");
        //yield return StartCoroutine("Skip");
        panel.SetActive(false);
        uitext.DrawText("");
        yield return 0;
        messageFlag = true;
        playerFlag.SetDestroyFlag(false);
    }

    // 読み終わったかどうかの確認
    public bool IsAlreadyRead()
    {
        return messageFlag;
    }
    public void SetAlreadyRead(bool alreadyRead)
    {
        messageFlag = alreadyRead;
    }
}