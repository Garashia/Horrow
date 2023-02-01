using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalObjectManager : MonoBehaviour
{
    [SerializeField]
    private TextWriter notItem;
    [SerializeField]
    private TextWriter haveFlashLight;
    [SerializeField]
    private TextWriter haveButtery;

    [SerializeField]
    private Item flashLight;

    [SerializeField]
    private Item buttery;

    [SerializeField]
    private float size;

    private bool near;
    private GameObject playerObject;
    private bool clearFlag;

    public float Size { get => size; set => size = value; }

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.FindWithTag("Player");
        near = false;
        clearFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
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
                if (flashLight.GetItemFlag())
                {
                    if (buttery.GetItemFlag())
                        haveButtery.RenderMessage();
                    else
                        haveFlashLight.RenderMessage();
                }
                else
                {
                    notItem.RenderMessage();
                }
            }
        if (haveButtery.IsAlreadyRead())
        {
            clearFlag = true;
            haveButtery.SetAlreadyRead(false);
        }
        if (haveFlashLight.IsAlreadyRead())
        {
            haveFlashLight.SetAlreadyRead(false);
        }
        if (notItem.IsAlreadyRead())
        {
            notItem.SetAlreadyRead(false);
        }

    }

    public bool GetClearFlag()
    {
        return clearFlag;
    }
    public void SetClearFlag(bool afterClear)
    {
        clearFlag = afterClear;
    }

}
