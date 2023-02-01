using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TitleScene : MonoBehaviour
{
    [SerializeField] Fade fade;

    //  Space����������1�b�ԉ��o�������āA�V�[���ڍs
    void Update()
    {
        RoomScene1();
    }

    private void RoomScene1()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fade.FadeIn(1f, () => SceneManager.LoadScene("RoomScene1"));
        }
    }
}
