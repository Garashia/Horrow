using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoManager : MonoBehaviour
{
    [SerializeField]
    private DestroyFlag flag;
    [SerializeField]
    private GameObject message;
    [SerializeField]
    private Vector2 pos;
    private bool IsActive;

    [SerializeField]
    private GameObject memo;

    private GameObject playerObject;

    [SerializeField]
    private float size;

    private bool near;
    private bool IsMemo;

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.FindWithTag("Player");
        near = false;
        IsMemo = false;
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
            near = true;
        }
        else
        {
            message.SetActive(false);
            near = false;
        }

        if (near)
        {                
            if (Input.GetKeyDown(KeyCode.Space))
            {

                if (!IsMemo)
                {
                    flag.SetDestroyFlag(true);
                    IsActive = false;
                     memo.SetActive(true);
                     IsMemo = true;
                    
                }
                
                else
                {
                    flag.SetDestroyFlag(false);
                    IsActive = true;
                     memo.SetActive(false);
                     IsMemo = false;

                }
            }
        }

    }
}