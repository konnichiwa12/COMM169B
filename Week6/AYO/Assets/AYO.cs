using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AYO : MonoBehaviour
{
    // Start is called before the first frame update
    int shrink;
    void Start()
    {
        shrink = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.x > 2)
        {
            shrink = 1;
        }
        else if (transform.localScale.x < 1)
        {
            shrink = 0;
        }

        if (shrink == 1)
        {
            transform.localScale -= new Vector3(0.03f, 0.03f, 0.03f);
        }
        else
        {
            transform.localScale += new Vector3(0.03f, 0.03f, 0.03f);
        }
    }
}
