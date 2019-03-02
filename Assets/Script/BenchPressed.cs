using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BenchPressed : MonoBehaviour
{

    private float StartYPos;
    private float yPos;
    float maxLevel;
    bool win;

    [SerializeField]
    GameObject WinScreen;

    [SerializeField]
    GameObject LooseScreen;

    [SerializeField]
    GameObject GameMaster;

    // Start is called before the first frame update
    void Start()
    {
        win = false;
        StartYPos = this.transform.position.y;
        yPos = StartYPos;
        maxLevel = 40.0f;

        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Hit") && yPos <= maxLevel)
        {

            yPos += 2;
            this.transform.position = (new Vector3(this.transform.position.x, yPos, this.transform.position.z));
            win = true;


        }

        if(yPos > StartYPos && yPos <= maxLevel)
        {
            yPos -= 0.1f;
            this.transform.position = (new Vector3(this.transform.position.x, yPos, this.transform.position.z));

        }


        if (yPos >= maxLevel)
            WinScreen.SetActive(true);


    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(5.0f);

        if(win == false)
            LooseScreen.SetActive(true);
    }


}
