using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hoge : MonoBehaviour
{
    [SerializeField] Fade fade;
    [SerializeField] private DestroyFlag flag;
    private void Start()
    {
        flag.SetDestroyFlag(false);
        fade.FadeOut(1f);
    }
}
