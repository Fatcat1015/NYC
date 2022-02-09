using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_tag : MonoBehaviour
{
    public GameObject change_object;
    public GameObject cancel_object;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        cancel_object.gameObject.tag = "Untagged";
        change_object.gameObject.tag = "follow";
    }
}
