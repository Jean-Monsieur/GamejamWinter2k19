using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BenchPressed : MonoBehaviour
{

    private float StartYPos;
    private float yPos;
    float maxLevel;

    // Start is called before the first frame update
    void Start()
    {

        StartYPos = this.transform.position.y;
        yPos = StartYPos;
        maxLevel = 40.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Hit") && yPos <= maxLevel)
        {

            yPos += 2;
            this.transform.position = (new Vector3(this.transform.position.x, yPos, this.transform.position.z));

        }

        if(yPos > StartYPos && yPos <= maxLevel)
        {
            yPos -= 0.1f;
            this.transform.position = (new Vector3(this.transform.position.x, yPos, this.transform.position.z));

        }


    }


   
}
