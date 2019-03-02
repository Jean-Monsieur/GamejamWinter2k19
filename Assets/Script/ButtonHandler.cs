using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{


    public void Click_StatsMenu()
    {

        if(this.gameObject.activeSelf == true)
            this.gameObject.SetActive(false);
        else
            this.gameObject.SetActive(true);

    }

}
