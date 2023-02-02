using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxManager : MonoBehaviour
{
    [SerializeField]
    private DestroyFlag playerFlag;

    [SerializeField]
    private GameObject message;
    [SerializeField]
    private Vector2 pos;
    private bool IsActive;

    [SerializeField]
    private TextWriter notHammer;
    [SerializeField]
    private TextWriter haveHammer;
    [SerializeField]
    private TextWriter afterBreak;

    [SerializeField]
    private Item hammer;

    [SerializeField]
    private Item flashLifht;

    [SerializeField]
    private float size;

    [SerializeField]
    private GameObject box;

    [SerializeField]
    private GameObject boxDead;

    [SerializeField]
    private DestroyFlag isBox;

    private bool near;
    private GameObject playerObject;

    public float Size { get => size; set => size = value; }

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.FindWithTag("Player");
        near = false;
        message = Instantiate(message);
        message.transform.position = new Vector3(gameObject.transform.position.x + pos.x, gameObject.transform.position.y + pos.y, 0.0f);
        IsActive = true;

    }

    // Update is called once per frame
    void Update()
    {
        if(isBox.GetDestroyFlag())
        {
            Destroy(gameObject);
            box.SetActive(false);
            boxDead.SetActive(true);
        }
        if (playerObject.transform.position.x - Size < transform.position.x &&
            playerObject.transform.position.x + Size > transform.position.x)
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
            if (Input.GetKeyDown(KeyCode.Space))
            {
                IsActive = false;
                if (flashLifht.GetItemFlag())
                {
                    afterBreak.RenderMessage();
                }
                else if (hammer.GetItemFlag())
                {
                    haveHammer.RenderMessage();
                }
                else
                {
                    notHammer.RenderMessage();
                }
            }
        if (afterBreak.IsAlreadyRead())
        {
            IsActive = true;
            afterBreak.SetAlreadyRead(false);
        }
        if (haveHammer.IsAlreadyRead())
        {
            IsActive = true;
            flashLifht.SetItemFlag(true);
            isBox.SetDestroyFlag(true);
            Destroy(gameObject);
            haveHammer.SetAlreadyRead(false);
        }
        if(notHammer.IsAlreadyRead())
        {
            IsActive = true;
            notHammer.SetAlreadyRead(false);
        }

    }
}
