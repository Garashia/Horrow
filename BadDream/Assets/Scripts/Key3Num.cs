using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key3Num : MonoBehaviour
{
    //  鍵画像の配列
    [SerializeField]
    GameObject[] Key3 = new GameObject[10];

    //  番号
    int keyNum3 = 0;

    //  クリアフラグ
    private bool Key3_clearFlag;

    //  初期化
    void Start()
    {
        Key3[0].SetActive(true);

        Key3[1].SetActive(false);
        Key3[2].SetActive(false);
        Key3[3].SetActive(false);
        Key3[4].SetActive(false);
        Key3[5].SetActive(false);
        Key3[6].SetActive(false);
        Key3[7].SetActive(false);
        Key3[8].SetActive(false);
        Key3[9].SetActive(false);

        Key3_clearFlag = false;
    }

    void Update()
    {
        if (KeySelectManager.pushNum == 2)
        {

            //  番号切り替え
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (keyNum3 > 0) keyNum3--;
                else keyNum3 = 9;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                if (keyNum3 <= 8) keyNum3++;
                else keyNum3 = 0;
            }

            if (keyNum3 == 0)
            {
                Key3[0].SetActive(true);

                Key3[1].SetActive(false);
                Key3[2].SetActive(false);
                Key3[3].SetActive(false);
                Key3[4].SetActive(false);
                Key3[5].SetActive(false);
                Key3[6].SetActive(false);
                Key3[7].SetActive(false);
                Key3[8].SetActive(false);
                Key3[9].SetActive(false);
            }
            else if (keyNum3 == 1)
            {
                Key3[1].SetActive(true);

                Key3[0].SetActive(false);
                Key3[2].SetActive(false);
                Key3[3].SetActive(false);
                Key3[4].SetActive(false);
                Key3[5].SetActive(false);
                Key3[6].SetActive(false);
                Key3[7].SetActive(false);
                Key3[8].SetActive(false);
                Key3[9].SetActive(false);
            }
            else if (keyNum3 == 2)
            {
                Key3[2].SetActive(true);

                Key3[0].SetActive(false);
                Key3[1].SetActive(false);
                Key3[3].SetActive(false);
                Key3[4].SetActive(false);
                Key3[5].SetActive(false);
                Key3[6].SetActive(false);
                Key3[7].SetActive(false);
                Key3[8].SetActive(false);
                Key3[9].SetActive(false);
            }
            else if (keyNum3 == 3)
            {
                Key3[3].SetActive(true);

                Key3[0].SetActive(false);
                Key3[2].SetActive(false);
                Key3[1].SetActive(false);
                Key3[4].SetActive(false);
                Key3[5].SetActive(false);
                Key3[6].SetActive(false);
                Key3[7].SetActive(false);
                Key3[8].SetActive(false);
                Key3[9].SetActive(false);
            }
            else if (keyNum3 == 4)
            {
                Key3[4].SetActive(true);

                Key3[0].SetActive(false);
                Key3[2].SetActive(false);
                Key3[3].SetActive(false);
                Key3[1].SetActive(false);
                Key3[5].SetActive(false);
                Key3[6].SetActive(false);
                Key3[7].SetActive(false);
                Key3[8].SetActive(false);
                Key3[9].SetActive(false);
            }
            else if (keyNum3 == 5)
            {
                Key3[5].SetActive(true);

                Key3[0].SetActive(false);
                Key3[2].SetActive(false);
                Key3[3].SetActive(false);
                Key3[4].SetActive(false);
                Key3[1].SetActive(false);
                Key3[6].SetActive(false);
                Key3[7].SetActive(false);
                Key3[8].SetActive(false);
                Key3[9].SetActive(false);
            }
            else if (keyNum3 == 6)
            {
                Key3[6].SetActive(true);

                Key3[0].SetActive(false);
                Key3[2].SetActive(false);
                Key3[3].SetActive(false);
                Key3[4].SetActive(false);
                Key3[5].SetActive(false);
                Key3[1].SetActive(false);
                Key3[7].SetActive(false);
                Key3[8].SetActive(false);
                Key3[9].SetActive(false);
            }
            else if (keyNum3 == 7)
            {
                Key3[7].SetActive(true);

                Key3[0].SetActive(false);
                Key3[2].SetActive(false);
                Key3[3].SetActive(false);
                Key3[4].SetActive(false);
                Key3[5].SetActive(false);
                Key3[6].SetActive(false);
                Key3[1].SetActive(false);
                Key3[8].SetActive(false);
                Key3[9].SetActive(false);
            }
            else if (keyNum3 == 8)
            {
                Key3[8].SetActive(true);

                Key3[0].SetActive(false);
                Key3[2].SetActive(false);
                Key3[3].SetActive(false);
                Key3[4].SetActive(false);
                Key3[5].SetActive(false);
                Key3[6].SetActive(false);
                Key3[7].SetActive(false);
                Key3[1].SetActive(false);
                Key3[9].SetActive(false);
            }
            else
            {
                Key3[9].SetActive(true);

                Key3[0].SetActive(false);
                Key3[2].SetActive(false);
                Key3[3].SetActive(false);
                Key3[4].SetActive(false);
                Key3[5].SetActive(false);
                Key3[6].SetActive(false);
                Key3[7].SetActive(false);
                Key3[8].SetActive(false);
                Key3[1].SetActive(false);
            }
        }

        //  正解
        if (keyNum3 == 2)
        {
            Key3_clearFlag = true;
        }
        else
        {
            Key3_clearFlag = false;
        }

    }
    public bool GetKey3_clearFlag()
    {
        return Key3_clearFlag;
    }

}
