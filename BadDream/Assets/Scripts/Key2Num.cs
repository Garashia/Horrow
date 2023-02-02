using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key2Num : MonoBehaviour
{
    //  鍵画像の配列
    [SerializeField]
    GameObject[] Key2 = new GameObject[10];

    //  番号
    int keyNum2 = 0;

    //  クリアフラグ
    private bool Key2_clearFlag;

    //  初期化
    void Start()
    {
        Key2[0].SetActive(true);

        Key2[1].SetActive(false);
        Key2[2].SetActive(false);
        Key2[3].SetActive(false);
        Key2[4].SetActive(false);
        Key2[5].SetActive(false);
        Key2[6].SetActive(false);
        Key2[7].SetActive(false);
        Key2[8].SetActive(false);
        Key2[9].SetActive(false);

        Key2_clearFlag = false;
    }

    void Update()
    {
        if (KeySelectManager.pushNum == 1)
        {

            //  番号切り替え
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (keyNum2 > 0) keyNum2--;
                else keyNum2 = 9;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                if (keyNum2 <= 8) keyNum2++;
                else keyNum2 = 0;
            }

            if (keyNum2 == 0)
            {
                Key2[0].SetActive(true);

                Key2[1].SetActive(false);
                Key2[2].SetActive(false);
                Key2[3].SetActive(false);
                Key2[4].SetActive(false);
                Key2[5].SetActive(false);
                Key2[6].SetActive(false);
                Key2[7].SetActive(false);
                Key2[8].SetActive(false);
                Key2[9].SetActive(false);
            }
            else if (keyNum2 == 1)
            {
                Key2[1].SetActive(true);

                Key2[0].SetActive(false);
                Key2[2].SetActive(false);
                Key2[3].SetActive(false);
                Key2[4].SetActive(false);
                Key2[5].SetActive(false);
                Key2[6].SetActive(false);
                Key2[7].SetActive(false);
                Key2[8].SetActive(false);
                Key2[9].SetActive(false);
            }
            else if (keyNum2 == 2)
            {
                Key2[2].SetActive(true);

                Key2[0].SetActive(false);
                Key2[1].SetActive(false);
                Key2[3].SetActive(false);
                Key2[4].SetActive(false);
                Key2[5].SetActive(false);
                Key2[6].SetActive(false);
                Key2[7].SetActive(false);
                Key2[8].SetActive(false);
                Key2[9].SetActive(false);
            }
            else if (keyNum2 == 3)
            {
                Key2[3].SetActive(true);

                Key2[0].SetActive(false);
                Key2[2].SetActive(false);
                Key2[1].SetActive(false);
                Key2[4].SetActive(false);
                Key2[5].SetActive(false);
                Key2[6].SetActive(false);
                Key2[7].SetActive(false);
                Key2[8].SetActive(false);
                Key2[9].SetActive(false);
            }
            else if (keyNum2 == 4)
            {
                Key2[4].SetActive(true);

                Key2[0].SetActive(false);
                Key2[2].SetActive(false);
                Key2[3].SetActive(false);
                Key2[1].SetActive(false);
                Key2[5].SetActive(false);
                Key2[6].SetActive(false);
                Key2[7].SetActive(false);
                Key2[8].SetActive(false);
                Key2[9].SetActive(false);
            }
            else if (keyNum2 == 5)
            {
                Key2[5].SetActive(true);

                Key2[0].SetActive(false);
                Key2[2].SetActive(false);
                Key2[3].SetActive(false);
                Key2[4].SetActive(false);
                Key2[1].SetActive(false);
                Key2[6].SetActive(false);
                Key2[7].SetActive(false);
                Key2[8].SetActive(false);
                Key2[9].SetActive(false);
            }
            else if (keyNum2 == 6)
            {
                Key2[6].SetActive(true);

                Key2[0].SetActive(false);
                Key2[2].SetActive(false);
                Key2[3].SetActive(false);
                Key2[4].SetActive(false);
                Key2[5].SetActive(false);
                Key2[1].SetActive(false);
                Key2[7].SetActive(false);
                Key2[8].SetActive(false);
                Key2[9].SetActive(false);
            }
            else if (keyNum2 == 7)
            {
                Key2[7].SetActive(true);

                Key2[0].SetActive(false);
                Key2[2].SetActive(false);
                Key2[3].SetActive(false);
                Key2[4].SetActive(false);
                Key2[5].SetActive(false);
                Key2[6].SetActive(false);
                Key2[1].SetActive(false);
                Key2[8].SetActive(false);
                Key2[9].SetActive(false);
            }
            else if (keyNum2 == 8)
            {
                Key2[8].SetActive(true);

                Key2[0].SetActive(false);
                Key2[2].SetActive(false);
                Key2[3].SetActive(false);
                Key2[4].SetActive(false);
                Key2[5].SetActive(false);
                Key2[6].SetActive(false);
                Key2[7].SetActive(false);
                Key2[1].SetActive(false);
                Key2[9].SetActive(false);
            }
            else
            {
                Key2[9].SetActive(true);

                Key2[0].SetActive(false);
                Key2[2].SetActive(false);
                Key2[3].SetActive(false);
                Key2[4].SetActive(false);
                Key2[5].SetActive(false);
                Key2[6].SetActive(false);
                Key2[7].SetActive(false);
                Key2[8].SetActive(false);
                Key2[1].SetActive(false);
            }
        }

        //  正解
        if (keyNum2 == 4)
        {
            Key2_clearFlag = true;
        }
        else
        {
            Key2_clearFlag = false;
        }

    }
    public bool GetKey2_clearFlag()
    {
        return Key2_clearFlag;
    }

}
