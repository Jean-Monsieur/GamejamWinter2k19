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

    [SerializeField]
    Sprite player;

    int Strenght;
    int hit;
    int hitPosition;

    // Start is called before the first frame update
    void Start()
    {
        win = false;
        StartYPos = this.transform.position.y;
        yPos = StartYPos;
        maxLevel = 40.0f;
        hitPosition = 1;
        hit = 0;
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Hit") && yPos <= maxLevel)
        {
            hit += 1;
            //yPos += 2;
            //this.transform.position = (new Vector3(this.transform.position.x, yPos, this.transform.position.z));
            if(hit == 3)
            {
                hitPosition += 1;
                player = Resources.Load<Sprite>("Sprites/Benchpress/sprite01");
            }
            

        }

        if(yPos > StartYPos && yPos <= maxLevel)
        {
            yPos -= 0.1f;
            this.transform.position = (new Vector3(this.transform.position.x, yPos, this.transform.position.z));

        }


        if (yPos >= maxLevel)
        {
            GameMaster.GetComponent<GameMaster>().setStrenght(5);
            WinScreen.SetActive(true);
            win = true;
        }



    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(5.0f);

        if(win == false)
            LooseScreen.SetActive(true);
    }


}
