using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HosiManager : MonoBehaviour
{
    [SerializeField]
    private GameObject message;
    [SerializeField]
    private Vector2 pos;
    private bool IsActive;

    private bool IsKey;
    private GameObject playerObject;
    [SerializeField]
    private Item keyItem;

    [SerializeField]
    private TextWriter textWriter;

    [SerializeField]
    private float size;

    [SerializeField]
    private DestroyFlag isDead;

    // Start is called before the first frame update
    void Start()
    {
        IsKey = false;
        playerObject = GameObject.FindWithTag("Player");
        message = Instantiate(message);
        message.transform.position = new Vector3(gameObject.transform.position.x + pos.x, gameObject.transform.position.y + pos.y, 0.0f);
        IsActive = true;
    }

    private void Update()
    {
        if (isDead.GetDestroyFlag())
        {
            Destroy(gameObject);
        }
        else
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
            if (IsKey)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    IsActive = false;

                    textWriter.RenderMessage();
                    //if (textWriter.IsAlreadyRead())
                    //{
                    //keyItem.itemGetFlag = true;
                    //Destroy(gameObject);
                    //    textWriter.SetAlreadyRead(false);
                    //}
                    //ItemFlag.SetItem(true, ItemFlag.Item.Key);
                    //keyItem.SetItem(true, ItemFlag.Item.Key);
                }
            }
            Debug.Log(IsKey);
            if (textWriter.IsAlreadyRead())
            {
                Destroy(gameObject);
                textWriter.SetAlreadyRead(false);
                isDead.isDead = true;
                keyItem.SetItemFlag(true);
            }
        }
    }
    
}
