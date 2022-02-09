using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class text : MonoBehaviour
{
    public TMP_Text textt;
    public string reset_text;
    public string w_text;
    public string s_text;
    public string a_text;
    public string d_text;

    public TMP_FontAsset title;
    public TMP_FontAsset other;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            textt.text = reset_text;
            textt.font = title;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            textt.font = other;
            textt.text = a_text;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            textt.font = other;
            textt.text = s_text;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            textt.font = other;
            textt.text = w_text;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            textt.font = other;
            textt.text = d_text;
        }
    }

}
