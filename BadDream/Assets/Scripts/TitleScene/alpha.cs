using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alpha : MonoBehaviour
{
    float time;
    //float alpha_num = -255;

    float alpha_Sin;

    SpriteRenderer textureRenderer;

    private void Start()
    {
        textureRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        //StartCoroutine(alphaPoint());
        float sin = Mathf.Sin(Time.time * 4);
        sin *= 255;
        textureRenderer.color = new Color(textureRenderer.color.r, textureRenderer.color.g, textureRenderer.color.b, sin);
    }

    //private IEnumerator alphaPoint()
    //{
    //    while(alpha_num > 255)
    //    {
    //        alpha_Sin += /*Mathf.Sin(Time.time) / 2 +*/ 0.5f;

    //        Debug.Log(alpha_Sin);

    //        this.GetComponent<SpriteRenderer>().color += new Color(0, 0, 0, alpha_Sin);
    //        yield return new WaitForSeconds(0.1f);

    //    }

    //}


}

