using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleAlpha : MonoBehaviour
{
    SpriteRenderer textureRenderer;



    private void Start()
    {
        textureRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        textureRenderer.color = new Color(textureRenderer.color.r, textureRenderer.color.g, textureRenderer.color.b, 0);
    }
}
