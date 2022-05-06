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
        Physics.gravity = new Vector3(0, -0.4F, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.y > 2)
        {
            shrink = 1;
        }
        else if (transform.localScale.y < 1)
        {
            shrink = 0;
        }

        if (shrink == 1)
        {
            transform.localScale -= new Vector3(0f, 0.005f, 0f);
        }
        else
        {
            transform.localScale += new Vector3(0f, 1f, 0f);
        }



    }
}
