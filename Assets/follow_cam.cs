using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_cam : MonoBehaviour
{
    public GameObject follow_object;

    // Update is called once per frame
    void Update()
    {
        follow_object = GameObject.FindGameObjectWithTag("follow");
        gameObject.transform.position = new Vector3(follow_object.transform.position.x, follow_object.transform.position.y,-10);
    }
}
