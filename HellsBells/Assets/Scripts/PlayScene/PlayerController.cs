using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float speed;


    private Rigidbody2D rb;

    private SpriteRenderer renderer;

    [SerializeField]
    private Animator animator = null;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        renderer = GetComponent<SpriteRenderer>();
        this.animator = GetComponent<Animator>();
    }

    // 物理演算をしたい場合はFixedUpdateを使うのが一般的
    void FixedUpdate()
    {

        Vector2 move = new Vector2(0.0f, 0.0f);
        //右入力で左向きに動く
        if (Input.GetKey(KeyCode.RightArrow))
        {
            move.x = speed;
            renderer.flipX = false;
        }
        //左入力で左向きに動く
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            move.x = -speed;
            renderer.flipX = true;
        }
        //停止
        else
        {
            rb.velocity = Vector2.zero;
        }
        //if (Input.GetKey(KeyCode.RightShift))
        //{
        //    animator.SetTrigger("Back");

        //}


        animator.SetFloat("speed", move.magnitude);

        move.Normalize();

        move *= 0.1f;


        Vector2 pos = new Vector2(
            rb.position.x + move.x,
            rb.position.y + move.y);

        rb.MovePosition(pos);

        this.animator.speed = speed / 20.0f;

    }


}
