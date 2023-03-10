using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float speed;


    private Rigidbody2D rb;

    private new SpriteRenderer renderer;

    [SerializeField]
    private Animator animator = null;

    [SerializeField]
    private DestroyFlag flag;

    //[SerializeField]
    private new BoxCollider2D collider2D;
    [SerializeField]
    private GameObject collderObj;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        renderer = GetComponent<SpriteRenderer>();
        this.animator = GetComponent<Animator>();
        collider2D = collderObj.GetComponent<BoxCollider2D>();
    }

    // 物理演算をしたい場合はFixedUpdateを使うのが一般的
    void FixedUpdate()
    {
        if (!flag.GetDestroyFlag()) 
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

            if(rb.position.x < collderObj.transform.position.x - (collider2D.size.x * collderObj.transform.localScale.x / 2))
            {
                gameObject.transform.position = new Vector2(collderObj.transform.position.x - (collider2D.size.x * collderObj.transform.localScale.x / 2) - 0.1f, rb.position.y);
            }
            if(rb.position.x > collderObj.transform.position.x + (collider2D.size.x * collderObj.transform.localScale.x / 2))
            {
                gameObject.transform.position = new Vector2(collderObj.transform.position.x + (collider2D.size.x * collderObj.transform.localScale.x / 2) + 0.1f, rb.position.y);
            }
        }

    }
}
