using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key4Num : MonoBehaviour
{
    //  鍵画像の配列
    [SerializeField]
    GameObject[] Key4 = new GameObject[10];

    //  番号
    int keyNum4 = 0;

    //  クリアフラグ
    private bool Key4_clearFlag;

    //  初期化
    void Start()
    {
        Key4[0].SetActive(true);

        Key4[1].SetActive(false);
        Key4[2].SetActive(false);
        Key4[3].SetActive(false);
        Key4[4].SetActive(false);
        Key4[5].SetActive(false);
        Key4[6].SetActive(false);
        Key4[7].SetActive(false);
        Key4[8].SetActive(false);
        Key4[9].SetActive(false);

        Key4_clearFlag = false;
    }

    void Update()
    {
        if (KeySelectManager.pushNum == 3)
        {
            //  番号切り替え
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (keyNum4 > 0) keyNum4--;
                else keyNum4 = 9;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                if (keyNum4 <= 8) keyNum4++;
                else keyNum4 = 0;
            }

            if (keyNum4 == 0)
            {
                Key4[0].SetActive(true);

                Key4[1].SetActive(false);
                Key4[2].SetActive(false);
                Key4[3].SetActive(false);
                Key4[4].SetActive(false);
                Key4[5].SetActive(false);
                Key4[6].SetActive(false);
                Key4[7].SetActive(false);
                Key4[8].SetActive(false);
                Key4[9].SetActive(false);
            }
            else if (keyNum4 == 1)
            {
                Key4[1].SetActive(true);

                Key4[0].SetActive(false);
                Key4[2].SetActive(false);
                Key4[3].SetActive(false);
                Key4[4].SetActive(false);
                Key4[5].SetActive(false);
                Key4[6].SetActive(false);
                Key4[7].SetActive(false);
                Key4[8].SetActive(false);
                Key4[9].SetActive(false);
            }
            else if (keyNum4 == 2)
            {
                Key4[2].SetActive(true);

                Key4[0].SetActive(false);
                Key4[1].SetActive(false);
                Key4[3].SetActive(false);
                Key4[4].SetActive(false);
                Key4[5].SetActive(false);
                Key4[6].SetActive(false);
                Key4[7].SetActive(false);
                Key4[8].SetActive(false);
                Key4[9].SetActive(false);
            }
            else if (keyNum4 == 3)
            {
                Key4[3].SetActive(true);

                Key4[0].SetActive(false);
                Key4[2].SetActive(false);
                Key4[1].SetActive(false);
                Key4[4].SetActive(false);
                Key4[5].SetActive(false);
                Key4[6].SetActive(false);
                Key4[7].SetActive(false);
                Key4[8].SetActive(false);
                Key4[9].SetActive(false);
            }
            else if (keyNum4 == 4)
            {
                Key4[4].SetActive(true);

                Key4[0].SetActive(false);
                Key4[2].SetActive(false);
                Key4[3].SetActive(false);
                Key4[1].SetActive(false);
                Key4[5].SetActive(false);
                Key4[6].SetActive(false);
                Key4[7].SetActive(false);
                Key4[8].SetActive(false);
                Key4[9].SetActive(false);
            }
            else if (keyNum4 == 5)
            {
                Key4[5].SetActive(true);

                Key4[0].SetActive(false);
                Key4[2].SetActive(false);
                Key4[3].SetActive(false);
                Key4[4].SetActive(false);
                Key4[1].SetActive(false);
                Key4[6].SetActive(false);
                Key4[7].SetActive(false);
                Key4[8].SetActive(false);
                Key4[9].SetActive(false);
            }
            else if (keyNum4 == 6)
            {
                Key4[6].SetActive(true);

                Key4[0].SetActive(false);
                Key4[2].SetActive(false);
                Key4[3].SetActive(false);
                Key4[4].SetActive(false);
                Key4[5].SetActive(false);
                Key4[1].SetActive(false);
                Key4[7].SetActive(false);
                Key4[8].SetActive(false);
                Key4[9].SetActive(false);
            }
            else if (keyNum4 == 7)
            {
                Key4[7].SetActive(true);

                Key4[0].SetActive(false);
                Key4[2].SetActive(false);
                Key4[3].SetActive(false);
                Key4[4].SetActive(false);
                Key4[5].SetActive(false);
                Key4[6].SetActive(false);
                Key4[1].SetActive(false);
                Key4[8].SetActive(false);
                Key4[9].SetActive(false);
            }
            else if (keyNum4 == 8)
            {
                Key4[8].SetActive(true);

                Key4[0].SetActive(false);
                Key4[2].SetActive(false);
                Key4[3].SetActive(false);
                Key4[4].SetActive(false);
                Key4[5].SetActive(false);
                Key4[6].SetActive(false);
                Key4[7].SetActive(false);
                Key4[1].SetActive(false);
                Key4[9].SetActive(false);
            }
            else
            {
                Key4[9].SetActive(true);

                Key4[0].SetActive(false);
                Key4[2].SetActive(false);
                Key4[3].SetActive(false);
                Key4[4].SetActive(false);
                Key4[5].SetActive(false);
                Key4[6].SetActive(false);
                Key4[7].SetActive(false);
                Key4[8].SetActive(false);
                Key4[1].SetActive(false);
            }
        }

        //  正解
        if (keyNum4 == 1)
        {
            Key4_clearFlag = true;
        }
        else
        {
            Key4_clearFlag = false;
        }

    }
    public bool GetKey4_clearFlag()
    {
        return Key4_clearFlag;
    }

}
