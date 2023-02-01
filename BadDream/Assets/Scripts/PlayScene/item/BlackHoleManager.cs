using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHoleManager : MonoBehaviour
{
    [SerializeField]
    private TextWriter noItem;

    [SerializeField]
    private TextWriter grassGet;

    [SerializeField]
    private TextWriter hammarGet;

    [SerializeField]
    private TextWriter butteryGet;

    [SerializeField]
    private Item hammerItem;
    [SerializeField]
    private Item grassItem;
    [SerializeField]
    private Item butteryItem;

    [SerializeField]
    private float size;

    private GameObject playerObject;

    private bool IsKey;
    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.FindWithTag("Player");
        IsKey = false;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (playerObject.transform.position.x - size < transform.position.x &&
            playerObject.transform.position.x + size > transform.position.x)
        {
            IsKey = true;
        }
        else
        {
            IsKey = false;
        }
        if (IsKey)
            if (Input.GetKeyDown(KeyCode.Space))
            {

                if (butteryItem.GetItemFlag())
                {
                    butteryGet.RenderMessage();
                    //if (butteryGet.IsAlreadyRead())
                    //    butteryGet.SetAlreadyRead(false);
                }
                else if (hammerItem.GetItemFlag())
                {
                    hammarGet.RenderMessage();
                    //if (hammarGet.IsAlreadyRead())
                    //{
                        //butteryItem.itemGetFlag = true;
                    //    hammarGet.SetAlreadyRead(false);
                    //}
                }
                else if (grassItem.GetItemFlag())
                {
                    grassGet.RenderMessage();
                    //if (grassGet.IsAlreadyRead())
                    //    grassGet.SetAlreadyRead(false);
                }
                else
                {
                    noItem.RenderMessage();
                    //if (noItem.IsAlreadyRead())
                    //    noItem.SetAlreadyRead(false);
                }
            }
        if (butteryGet.IsAlreadyRead())
            butteryGet.SetAlreadyRead(false);
        if (hammarGet.IsAlreadyRead())
        {
            butteryItem.itemGetFlag = true;
            hammarGet.SetAlreadyRead(false);
        }
        if (grassGet.IsAlreadyRead())
            grassGet.SetAlreadyRead(false);
        if (noItem.IsAlreadyRead())
            noItem.SetAlreadyRead(false);


    }
}
