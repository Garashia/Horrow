using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalObjectManager : MonoBehaviour
{
    [SerializeField]
    private DestroyFlag playerFlag;

    [SerializeField]
    private GameObject message;
    [SerializeField]
    private Vector2 pos;
    private bool IsActive;

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
        message = Instantiate(message);
        message.transform.position = new Vector3(gameObject.transform.position.x + pos.x, gameObject.transform.position.y + pos.y, 0.0f);
        IsActive = true;
    }

    // Update is called once per frame
    void Update()
    {
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
            IsActive = true;
            clearFlag = true;
            haveButtery.SetAlreadyRead(false);
        }
        if (haveFlashLight.IsAlreadyRead())
        {
            IsActive = true;
            haveFlashLight.SetAlreadyRead(false);
        }
        if (notItem.IsAlreadyRead())
        {
            IsActive = true;
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
