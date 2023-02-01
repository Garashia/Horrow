using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoManager : MonoBehaviour
{

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
    }

    // Update is called once per frame
    void Update()
    {
        if (playerObject.transform.position.x - size < transform.position.x &&
            playerObject.transform.position.x + size > transform.position.x)
        {
            near = true;
        }
        else
        {
            near = false;
        }

        if (near)
        {
            if (!IsMemo)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    memo.SetActive(true);
                    IsMemo = true;
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {

                    memo.SetActive(false);
                    IsMemo = false;
                }

            }
        }

    }
}