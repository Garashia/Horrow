using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    [SerializeField]
    private Item[] item;

    [SerializeField]
    private DestroyFlag[] des;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < item.Length; i++)
        {
            item[i].SetItemFlag(item[i].GetItemFlag());
        }
        for (int i = 0; i < des.Length; i++)
        {
            des[i].SetDestroyFlag(des[i].GetDestroyFlag());
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
