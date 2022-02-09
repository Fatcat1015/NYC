using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 3f;
    public float Jumpspeed = 7f;
    bool Jump = false;

    public BoxCollider2D col;

    void Start()
    {
        col = gameObject.GetComponent<BoxCollider2D>();
        //col.isTrigger = true;
    }

    void FixedUpdate()
    {
        moveplayer();

        if (Jump)
        {
            Jumpp();
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 15;
        }
        else
        {
            speed = 3;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(
                Random.Range(0f, 1f),
                Random.Range(0f, 1f),
                Random.Range(0f, 1f)
            );
        }
    }

    void moveplayer()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate((Vector2.left * Time.deltaTime) * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate((Vector2.right * Time.deltaTime) * speed);
        }


        //jump
        if (Input.GetKey(KeyCode.W)&&!Jump)
        {
            Jump = true;
        }

        if (Input.GetKey(KeyCode.S))
        {
            //transform.Translate((Vector2.down * Time.deltaTime) * speed);
        }

    }


    void Jumpp()
    {
        transform.Translate((Vector2.up * Time.deltaTime) * Jumpspeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Jump = false;
        }
    }
}
