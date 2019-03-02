using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GetDialog : MonoBehaviour
{

    public string Nom;
    public string TypeDialog;
    private string Dialog;
    
    // Start is called before the first frame update
    void Start()
    {
        try
        {
            //Load a text file (Assets/Resources/Text/textFile01.txt)
            var textFile = Resources.Load<TextAsset>("Dialog/"+Nom+"/"+TypeDialog);
            if (textFile == null)
            {
                Debug.LogError("Fichier text inexistant");
                throw new InvalidOperationException("Fichier inexistant");
            }
            else
                Dialog = textFile.text;
        }
        catch(Exception e)
        {
            Debug.Log(e.StackTrace.ToString());
            Debug.LogError("Erreur avec le fichier");
            this.enabled = false;
        }
    }

    public String getDialog()
    {
        return Dialog;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
