using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "Item", menuName = "CreateItem")]
public class Item : ScriptableObject
{
    public Type type; // 種類
    public String infomation; // 情報
    public Sprite sprite; // 画像(追加)
    private bool itemGetFlag;

    //private void Awake()
    //{
    //    itemGetFlag = false;
    //}

    public enum Type
    {
        Key, Cup, Flashlight, Hammer, Magnifying_Glass, Battery, Memo
    }

    public Item(Item item)
    {
        this.type = item.type;
        this.infomation = item.infomation;
        this.sprite = item.sprite; // 画像(追加)
        this.itemGetFlag = GetItemGetFlag(item);
    }

    private static bool GetItemGetFlag(Item item)
    {
        return item.itemGetFlag;
    }

    public bool GetItemFlag()
    {
        return this.itemGetFlag;
    }

    public void SetItemFlag(bool itemFlag)
    {
        itemGetFlag = itemFlag;
    }
}