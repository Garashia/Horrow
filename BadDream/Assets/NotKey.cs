using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotKey : MonoBehaviour
{
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
                IsKey = true;
            }
            else
            {
                IsKey = false;
            }
            if(IsKey)
            {
                if(Input.GetKeyDown(KeyCode.Space))
                if(keyItem.GetItemFlag())
                {
                    haveKey.RenderMessage();
                }
                else
                {
                    notKey.RenderMessage();
                }

            }

            if(haveKey.IsAlreadyRead())
            {
                door.SetActive(true);
                Destroy(gameObject);
                isDad.isDead = true;
                haveKey.SetAlreadyRead(false);
            }
            if(notKey.IsAlreadyRead())
            {
                notKey.SetAlreadyRead(false);
            }
        }
    }
}
