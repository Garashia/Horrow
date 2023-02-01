using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "flag", menuName = "CreateBoolBase")]
public class isTrue : ScriptableObject
{
    public List<DestroyFlag> des = new List<DestroyFlag>();

    public List<DestroyFlag> GetItemLists()
    {
        return des;
    }
}