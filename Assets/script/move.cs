using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    float speed = 3f;
    private Transform simpleobject;

    public enum Stages { stage1 = 1, stage2 = 2, stage3 = 3}
    public Stages stages = Stages.stage1;

    void FixedUpdate()
    {
        moveplayer();

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

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate((Vector2.up * Time.deltaTime) * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate((Vector2.down * Time.deltaTime) * speed);
        }

    }
}
