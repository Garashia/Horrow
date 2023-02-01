using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "DestroyFlag", menuName = "CreateBool")]
public class DestroyFlag : ScriptableObject
{
    //public Type type; // 種類
    //public String infomation; // 情報
    //public Sprite sprite; // 画像(追加)
    public bool isDead;

    //private void Awake()
    //{
    //    itemGetFlag = false;
    //}

    public DestroyFlag(DestroyFlag des)
    {
        this.isDead = des.isDead;
    }

    public bool GetDestroyFlag()
    {
        return this.isDead;
    }

    //public void SetDestroyFlag(bool deadFlag)
    //{
    //    isDead = deadFlag;
    //}
}