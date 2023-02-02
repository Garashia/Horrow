using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "Item", menuName = "CreateItem")]
public class Item : ScriptableObject
{
    public Type type; // í—Ş
    public String infomation; // î•ñ
    public Sprite sprite; // ‰æ‘œ(’Ç‰Á)
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
        this.sprite = item.sprite; // ‰æ‘œ(’Ç‰Á)
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