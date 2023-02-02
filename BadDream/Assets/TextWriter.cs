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
    // �N���b�N�҂��̃R���[�`��
    IEnumerator Skip()
    {
        while (uitext.playing) yield return 0;
        while (!uitext.IsClicked()) yield return 0;
    }

    // ���͂�\��������R���[�`��
    IEnumerator Cotest()
    {
        playerFlag.SetDestroyFlag(true);
        for (int i = 0; i < message.Length; i++)
        {
            uitext.DrawText(message[i]);
            yield return StartCoroutine(Skip());
        }

        //uitext.DrawText("���O", "�l���b���̂Ȃ炱��Ȋ���");
        //yield return StartCoroutine("Skip");
        panel.SetActive(false);
        uitext.DrawText("");
        yield return 0;
        messageFlag = true;
        playerFlag.SetDestroyFlag(false);
    }

    // �ǂݏI��������ǂ����̊m�F
    public bool IsAlreadyRead()
    {
        return messageFlag;
    }
    public void SetAlreadyRead(bool alreadyRead)
    {
        messageFlag = alreadyRead;
    }
}