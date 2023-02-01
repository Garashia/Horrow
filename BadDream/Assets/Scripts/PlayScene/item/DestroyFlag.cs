using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "DestroyFlag", menuName = "CreateBool")]
public class DestroyFlag : ScriptableObject
{
    //public Type type; // í—Ş
    //public String infomation; // î•ñ
    //public Sprite sprite; // ‰æ‘œ(’Ç‰Á)
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