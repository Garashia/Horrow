using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySelectManager : MonoBehaviour
{
    public static int pushNum = 0;
    [SerializeField]
    private GameObject Key1;
    [SerializeField]
    private GameObject Key2;
    [SerializeField]
    private GameObject Key3;
    [SerializeField]
    private GameObject Key4;

    [SerializeField]
    private float posY;
    // Update is called once per frame
    void Update()
    {
        //  ˆÚ“®”Ô†
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (pushNum > 0) pushNum--;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (pushNum < 3) pushNum++;
        }

        if (pushNum == 0)
        {
            this.transform.position = new Vector3(Key1.transform.position.x, Key1.transform.position.y + posY, 0);
        }
        else if (pushNum == 1)
        {
            this.transform.position = new Vector3(Key2.transform.position.x, Key2.transform.position.y + posY, 0);
        }
        else if (pushNum == 2)
        {
            this.transform.position = new Vector3(Key3.transform.position.x, Key3.transform.position.y + posY, 0);
        }
        else
        {
            this.transform.position = new Vector3(Key4.transform.position.x, Key4.transform.position.y + posY, 0);
        }

    }
}
