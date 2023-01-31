using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HosiManager : MonoBehaviour
{
    private bool IsKey;
    private GameObject playerObject;
    //[SerializeField]
    //private ItemFlag keyItem;

    [SerializeField]
    private float size;

    // Start is called before the first frame update
    void Start()
    {
        IsKey = false;
        playerObject = GameObject.FindWithTag("Player");
    }

    private void Update()
    {
        if (playerObject.transform.position.x - size < transform.position.x &&
    playerObject.transform.position.x + size > transform.position.x)
        {
            IsKey = true;
        }
        if(IsKey)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                //Destroy(gameObject);

                //ItemFlag.SetItem(true, ItemFlag.Item.Key);
                //keyItem.SetItem(true, ItemFlag.Item.Key);
            }
        }
    }
}
