using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange1 : MonoBehaviour
{
    [SerializeField]
    private Animator animator = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.RightShift))
        //{
        //    animator.SetTrigger("Back");
        //}

        bool isName = animator.GetCurrentAnimatorStateInfo(0).IsName("Back");
        bool isEnd = animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f;

        if (isName && isEnd)
        {
            SceneManager.LoadScene("room1");
        }

    }
}
