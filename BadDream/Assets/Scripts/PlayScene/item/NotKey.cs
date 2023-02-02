using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotKey : MonoBehaviour
{
    [SerializeField]
    private DestroyFlag playerFlag;

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
    private TextWriter notKey;
    [SerializeField]
    private TextWriter haveKey;

    [SerializeField]
    private GameObject door;

    [SerializeField]
    private float size;

    [SerializeField]
    private DestroyFlag isDad;

    // Start is called before the first frame update
    void Start()
    {
        IsKey = false;
        playerObject = GameObject.FindWithTag("Player");
        message = Instantiate(message);
        message.transform.position = new Vector3(gameObject.transform.position.x + pos.x, gameObject.transform.position.y + pos.y, 0.0f);
        IsActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isDad.GetDestroyFlag())
        {
            door.SetActive(true);
            Destroy(gameObject);
            //return;
        }
        else
        {

            
            if (playerObject.transform.position.x - size < transform.position.x &&
                playerObject.transform.position.x + size > transform.position.x)
            {
                if(IsActive)
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
            if(IsKey && !playerFlag.GetDestroyFlag())
            {
                if(Input.GetKeyDown(KeyCode.Space))
                {
                    IsActive = false;
                    if (keyItem.GetItemFlag())
                    {
                        haveKey.RenderMessage();
                    }
                    else
                    {
                        notKey.RenderMessage();
                    }

                }

            }

            if(haveKey.IsAlreadyRead())
            {
                IsActive = true;
                door.SetActive(true);
                Destroy(gameObject);
                isDad.SetDestroyFlag(true);
                haveKey.SetAlreadyRead(false);
            }
            if(notKey.IsAlreadyRead())
            {
                IsActive = true;
                notKey.SetAlreadyRead(false);
            }
        }
    }
}
