using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOfDrawersManager : MonoBehaviour
{
    [SerializeField]
    private DestroyFlag playerFlag;

    [SerializeField]
    private GameObject message;    

    [SerializeField]
    private Vector2 pos;
    [SerializeField]
    private float size;

    private bool IsActive;
    [SerializeField]
    private GameObject monitor;

    [SerializeField]
    private TextWriter tansuText;
    [SerializeField]
    private TextWriter haveHammer;

    [SerializeField]
    private TextWriter correct;
    [SerializeField]
    private TextWriter miss;


    private bool near;
    private GameObject playerObject;
    private bool nazotoki;

    [SerializeField]
    private Key1Num Key1;
    [SerializeField]
    private Key2Num Key2;
    [SerializeField]
    private Key3Num Key3;
    [SerializeField]
    private Key4Num Key4;

    [SerializeField]
    private Item hammer;

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.FindWithTag("Player");
        near = false;
        message = Instantiate(message);
        message.transform.position = new Vector3(gameObject.transform.position.x + pos.x, gameObject.transform.position.y + pos.y, 0.0f);
        IsActive = true;
        nazotoki = false;
    }

    // Update is called once per frame
    void Update()
    {

            if (playerObject.transform.position.x - size < transform.position.x &&
                playerObject.transform.position.x + size > transform.position.x)
            {
                if (IsActive)
                    message.SetActive(true);
                else
                    message.SetActive(false);

                near = true;
            }
            else
            {
                message.SetActive(false);

                near = false;
            }
            if (near && !playerFlag.GetDestroyFlag())
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (hammer.GetItemFlag())
                    {
                        haveHammer.RenderMessage();
                    }
                        else
                            {
                                IsActive = false;
                                tansuText.RenderMessage();

                            }

                }

            }
            else if(nazotoki)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                playerFlag.SetDestroyFlag(false);
                nazotoki = false;
                monitor.SetActive(false);
                if(!playerFlag.GetDestroyFlag())
                    if (Key1.GetKey1_clearFlag() &&
                        Key2.GetKey2_clearFlag() &&
                        Key3.GetKey3_clearFlag() &&
                        Key4.GetKey4_clearFlag())
                    {
                        correct.RenderMessage();
                    }
                    else
                    {
                        miss.RenderMessage();
                    }

            }
        }
            if (tansuText.IsAlreadyRead())
            {
                nazotoki = true;
                monitor.SetActive(true);
                tansuText.SetAlreadyRead(false);
                playerFlag.SetDestroyFlag(true);
            }
            if (haveHammer.IsAlreadyRead())
            {
                IsActive = true;
                haveHammer.SetAlreadyRead(false);
            }

        //if (nazotoki && playerFlag.GetDestroyFlag())
        //    {
        //        if(Input.GetKeyDown(KeyCode.Space))
        //        {
        //        }
        //    }

            if(correct.IsAlreadyRead())
            {
                IsActive = true;
                hammer.SetItemFlag(true);
                correct.SetAlreadyRead(false);
            }
            if(miss.IsAlreadyRead())
            {
            IsActive = true;
            miss.SetAlreadyRead(false);
            }
        }

}
