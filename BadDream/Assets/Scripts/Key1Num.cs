using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key1Num : MonoBehaviour
{
    //  鍵画像の配列
    [SerializeField]
    GameObject [] Key1 = new GameObject[10];
   
    //  番号
    int keyNum1 = 0;

    //  クリアフラグ
    private bool Key1_clearFlag;

    //  初期化
    void Start()
    {
        Key1[0].SetActive(true);

        Key1[1].SetActive(false);
        Key1[2].SetActive(false);
        Key1[3].SetActive(false);
        Key1[4].SetActive(false);
        Key1[5].SetActive(false);
        Key1[6].SetActive(false);
        Key1[7].SetActive(false);
        Key1[8].SetActive(false);
        Key1[9].SetActive(false);

        Key1_clearFlag = false;
    }

    void Update()
    {
        if (KeySelectManager.pushNum == 0)
        {

            //  番号切り替え
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (keyNum1 > 0) keyNum1--;
                else keyNum1 = 9;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                if (keyNum1 <= 8) keyNum1++;
                else keyNum1 = 0;
            }

            if (keyNum1 == 0)
            {
                Key1[0].SetActive(true);

                Key1[1].SetActive(false);
                Key1[2].SetActive(false);
                Key1[3].SetActive(false);
                Key1[4].SetActive(false);
                Key1[5].SetActive(false);
                Key1[6].SetActive(false);
                Key1[7].SetActive(false);
                Key1[8].SetActive(false);
                Key1[9].SetActive(false);
            }
            else if (keyNum1 == 1)
            {
                Key1[1].SetActive(true);

                Key1[0].SetActive(false);
                Key1[2].SetActive(false);
                Key1[3].SetActive(false);
                Key1[4].SetActive(false);
                Key1[5].SetActive(false);
                Key1[6].SetActive(false);
                Key1[7].SetActive(false);
                Key1[8].SetActive(false);
                Key1[9].SetActive(false);
            }
            else if (keyNum1 == 2)
            {
                Key1[2].SetActive(true);

                Key1[0].SetActive(false);
                Key1[1].SetActive(false);
                Key1[3].SetActive(false);
                Key1[4].SetActive(false);
                Key1[5].SetActive(false);
                Key1[6].SetActive(false);
                Key1[7].SetActive(false);
                Key1[8].SetActive(false);
                Key1[9].SetActive(false);
            }
            else if (keyNum1 == 3)
            {
                Key1[3].SetActive(true);

                Key1[0].SetActive(false);
                Key1[2].SetActive(false);
                Key1[1].SetActive(false);
                Key1[4].SetActive(false);
                Key1[5].SetActive(false);
                Key1[6].SetActive(false);
                Key1[7].SetActive(false);
                Key1[8].SetActive(false);
                Key1[9].SetActive(false);
            }
            else if (keyNum1 == 4)
            {
                Key1[4].SetActive(true);

                Key1[0].SetActive(false);
                Key1[2].SetActive(false);
                Key1[3].SetActive(false);
                Key1[1].SetActive(false);
                Key1[5].SetActive(false);
                Key1[6].SetActive(false);
                Key1[7].SetActive(false);
                Key1[8].SetActive(false);
                Key1[9].SetActive(false);
            }
            else if (keyNum1 == 5)
            {
                Key1[5].SetActive(true);

                Key1[0].SetActive(false);
                Key1[2].SetActive(false);
                Key1[3].SetActive(false);
                Key1[4].SetActive(false);
                Key1[1].SetActive(false);
                Key1[6].SetActive(false);
                Key1[7].SetActive(false);
                Key1[8].SetActive(false);
                Key1[9].SetActive(false);
            }
            else if (keyNum1 == 6)
            {
                Key1[6].SetActive(true);

                Key1[0].SetActive(false);
                Key1[2].SetActive(false);
                Key1[3].SetActive(false);
                Key1[4].SetActive(false);
                Key1[5].SetActive(false);
                Key1[1].SetActive(false);
                Key1[7].SetActive(false);
                Key1[8].SetActive(false);
                Key1[9].SetActive(false);
            }
            else if (keyNum1 == 7)
            {
                Key1[7].SetActive(true);

                Key1[0].SetActive(false);
                Key1[2].SetActive(false);
                Key1[3].SetActive(false);
                Key1[4].SetActive(false);
                Key1[5].SetActive(false);
                Key1[6].SetActive(false);
                Key1[1].SetActive(false);
                Key1[8].SetActive(false);
                Key1[9].SetActive(false);
            }
            else if (keyNum1 == 8)
            {
                Key1[8].SetActive(true);

                Key1[0].SetActive(false);
                Key1[2].SetActive(false);
                Key1[3].SetActive(false);
                Key1[4].SetActive(false);
                Key1[5].SetActive(false);
                Key1[6].SetActive(false);
                Key1[7].SetActive(false);
                Key1[1].SetActive(false);
                Key1[9].SetActive(false);
            }
            else
            {
                Key1[9].SetActive(true);

                Key1[0].SetActive(false);
                Key1[2].SetActive(false);
                Key1[3].SetActive(false);
                Key1[4].SetActive(false);
                Key1[5].SetActive(false);
                Key1[6].SetActive(false);
                Key1[7].SetActive(false);
                Key1[8].SetActive(false);
                Key1[1].SetActive(false);
            }
        }

        //  正解
        if(keyNum1 == 0)
        {
            Key1_clearFlag = true;
        }
        else
        {
            Key1_clearFlag = false;
        }

    }

    public bool GetKey1_clearFlag()
    {
        return Key1_clearFlag;
    }
}
