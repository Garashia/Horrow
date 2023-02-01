using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetItemIcon : MonoBehaviour
{
    [SerializeField]
    private ItemDataBase itemData;
    [SerializeField]
    private Canvas canvas;
    private GameObject[] itemIcon;
    private SpriteRenderer[] sprite;
    // Start is called before the first frame update
    void Start()
    {
        itemIcon = new GameObject[itemData.GetItemLists().Count];
        for(int i = 0; i < itemIcon.Length; i++)
        {
            //sprite = itemIcon.
            //itemIcon[i]
            //itemIcon[i] = Instantiate()
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
