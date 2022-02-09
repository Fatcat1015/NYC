using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class title : MonoBehaviour
{
    public TMP_Text thetext;

    private void Start()
    {
        thetext.text = "";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        thetext.text = "THE RUBE GOLDBERG MACHINE";
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            thetext.text = "";
    }
}
