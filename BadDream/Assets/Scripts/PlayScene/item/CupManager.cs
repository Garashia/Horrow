using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupManager : MonoBehaviour
{
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
    }

    // Update is called once per frame
    void Update()
    {
        bool IsKey = false;
        if (playerObject.transform.position.x - size < transform.position.x &&
            playerObject.transform.position.x + size > transform.position.x)
        {
            IsKey = true;
        }
        if (IsKey)
            if (Input.GetKeyDown(KeyCode.Space))
            {
                text.RenderMessage();

            }
        if (text.IsAlreadyRead())
        {
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
