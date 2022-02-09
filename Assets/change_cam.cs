using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_cam : MonoBehaviour
{

    public GameObject before;
    public GameObject after;

    private void Start()
    {

        after.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("player"))
        before.SetActive(false);
        after.SetActive(true);
        Destroy(this);
    }

}
