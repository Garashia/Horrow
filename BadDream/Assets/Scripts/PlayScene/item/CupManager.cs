using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupManager : MonoBehaviour
{
    [SerializeField]
    private DestroyFlag playerFlag;

    [SerializeField]
    private GameObject message;
    [SerializeField]
    private Vector2 pos;
    private bool IsActive;

    private bool examie;

    [SerializeField]
    private TextWriter text;

    [SerializeField]
    private float size;

    private GameObject playerObject;

    // Start is called before the first frame update
    void Start()
    {
        examie = false;
        playerObject = GameObject.FindWithTag("Player");
        message = Instantiate(message);
        message.transform.position = new Vector3(gameObject.transform.position.x + pos.x, gameObject.transform.position.y + pos.y, 0.0f);
        IsActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        bool IsKey = false;
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
        }
        if (IsKey && !playerFlag.GetDestroyFlag())
            if (Input.GetKeyDown(KeyCode.Space))
            {
                IsActive = false;
                text.RenderMessage();

            }
        if (text.IsAlreadyRead())
        {
            IsActive = true;
            examie = true;
            text.SetAlreadyRead(false);
        }

    }

    public bool IsExamie()
    {
        return examie;
    }

    public void SetExamie(bool ex)
    {
        examie = ex;
    }
}
