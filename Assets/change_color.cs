using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_color : MonoBehaviour
{
    public int color;
    public Color newcolor = new Color(1, 1, 1, 1);

    private void Start()
    {
        //Color newcolor = new Color(1, 1, 1, 1);
        switch (color)
        {
            case 1:
                newcolor = Color.red;
                break;

            case 2:
                newcolor = Color.yellow;
                break;

            case 3:
                newcolor = Color.green;
                break;

            case 4:
                newcolor = Color.cyan;
                break;

            case 5:
                newcolor = Color.blue;
                break;

            case 6:
                newcolor = Color.magenta;
                break;

            default:
                break;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        gameObject.GetComponent<SpriteRenderer>().color = newcolor;
    }
}
