using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxManager : MonoBehaviour
{
    [SerializeField]
    private TextWriter notHammer;
    [SerializeField]
    private TextWriter haveHammer;
    [SerializeField]
    private TextWriter afterBreak;

    [SerializeField]
    private Item hammer;

    [SerializeField]
    private Item flashLifht;

    private bool near;
    private GameObject playerObject;

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.FindWithTag("Player");
        near = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
