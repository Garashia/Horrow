using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagReset : MonoBehaviour
{
    [SerializeField]
    private Item[] itemData;

    [SerializeField]
    private DestroyFlag[] destroyFlags;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < itemData.Length; i++)
        {
            itemData[i].SetItemFlag(false);
        }
        for (int i = 0; i < destroyFlags.Length; i++)
        {
            destroyFlags[i].SetDestroyFlag(false);
        }

    }

}
