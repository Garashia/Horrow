using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Endingroll : MonoBehaviour
{
    Vector3 Staffrollposition;
    public RectTransform rectTransform;
    public float Endpos;
    private bool afterEnd;

    // Start is called before the first frame update
    void Start()
    {
        Staffrollposition = rectTransform.anchoredPosition;
        afterEnd = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (rectTransform.anchoredPosition.y < Endpos)
        {

            Staffrollposition.y += 1f/* **/ /*Time.deltaTime*/;
            rectTransform.anchoredPosition = Staffrollposition;
        }
        else
        {
            afterEnd = true;
        }
    }

    public bool GetAfterEnd()
    {
        return afterEnd;
    }

    public void SetAfterEnd(bool end)
    {
        afterEnd = end;
    }
}