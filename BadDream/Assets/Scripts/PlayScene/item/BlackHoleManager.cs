using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHoleManager : MonoBehaviour
{
    [SerializeField]
    private DestroyFlag playerFlag;
    [SerializeField]
    private GameObject message;
    [SerializeField]
    private Vector2 pos;
    private bool IsActive;

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
        message = Instantiate(message);
        message.transform.position = new Vector3(gameObject.transform.position.x + pos.x, gameObject.transform.position.y + pos.y, 0.0f);
        IsActive = true;
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
            IsKey = true;
        }
        else
        {
            message.SetActive(false);
            IsKey = false;
        }
        if (IsKey && !playerFlag.GetDestroyFlag())
            if (Input.GetKeyDown(KeyCode.Space))
            {
                IsActive = false;
                if (butteryItem.GetItemFlag() && hammerItem.GetItemFlag())
                {
                    hammarGet.RenderMessage();
                    //if (butteryGet.IsAlreadyRead())
                    //    butteryGet.SetAlreadyRead(false);
                }
                else if (butteryItem.GetItemFlag())
                {
                    butteryGet.RenderMessage();
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
        {
            IsActive = true;
            butteryGet.SetAlreadyRead(false);
        }
        if (hammarGet.IsAlreadyRead())
        {
            IsActive = true;
            butteryItem.SetItemFlag(true);
            hammarGet.SetAlreadyRead(false);
        }
        if (grassGet.IsAlreadyRead())
        {
            IsActive = true;
            grassGet.SetAlreadyRead(false);
        }
        if (noItem.IsAlreadyRead())
        {
            IsActive = true;
            noItem.SetAlreadyRead(false);
        }


    }
}
