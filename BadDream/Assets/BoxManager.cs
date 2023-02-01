using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxManager : MonoBehaviour
{
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
    }

    // Update is called once per frame
    void Update()
    {
        if(isBox.GetDestroyFlag())
        {
            box.SetActive(false);
            boxDead.SetActive(true);
        }
        if (playerObject.transform.position.x - Size < transform.position.x &&
            playerObject.transform.position.x + Size > transform.position.x)
        {
            near = true;
        }
        else
        {
            near = false;
        }
        if (near)
            if (Input.GetKeyDown(KeyCode.Space))
            {
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
            afterBreak.SetAlreadyRead(false);
        }
        if (haveHammer.IsAlreadyRead())
        {
            flashLifht.itemGetFlag = true;
            isBox.isDead = true;
            haveHammer.SetAlreadyRead(false);
        }
        if(notHammer.IsAlreadyRead())
        {
            notHammer.SetAlreadyRead(false);
        }

    }
}
