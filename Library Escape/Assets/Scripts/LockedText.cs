using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 


public class LockedText : MonoBehaviour
{
    public TextMeshProUGUI keyText;

    public static bool enableText;
    public static bool bronzeLock = false;
    public static bool silverLock = false;
    public static bool goldLock = false;
    bool hasPlayed = false;
    //bool hasAdded = false;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Canvas>().enabled = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (enableText && bronzeLock && Keys.bronzeKey == false && hasPlayed == false)
        {
            GetComponent<Canvas>().enabled = true;
            /*if (!hasAdded)
            {
                
            }*/
            bronzeLock = false; 
            keyText.text = "Locked, need bronze key";
            //hasAdded = true;
            Invoke("DisableText", 1.5f);
            hasPlayed = true; 
        }
        else if (enableText && bronzeLock && Keys.bronzeKey == true && hasPlayed == false)
        {
            // Open the drawer
            GetComponent<Canvas>().enabled = true;
            keyText.text = "Opened!";
            hasPlayed = true;
            Invoke("DisableText", 1.5f);
            bronzeLock = false;
        }
        else if (enableText && silverLock && Keys.silverKey == false && hasPlayed == false)
        {
            GetComponent<Canvas>().enabled = true;
            /*if (!hasAdded)
            {
                
            }*/
            keyText.text = "Locked, need silver key";
            //hasAdded = true;
            Invoke("DisableText", 1.5f);
            hasPlayed = true;
            silverLock = false;
        }
        else if (enableText && silverLock && Keys.silverKey == true && hasPlayed == false)
        {
            // Open the drawer
            GetComponent<Canvas>().enabled = true;
            keyText.text = "Opened!";
            hasPlayed = true;
            Invoke("DisableText", 1.5f);
            silverLock = false; 
        }
        if (enableText && goldLock && Keys.goldKey == false && hasPlayed == false)
        {
            GetComponent<Canvas>().enabled = true;
            /*if (!hasAdded)
            {
                
            }*/
            keyText.text = "Locked, need gold key";
            //hasAdded = true;
            Invoke("DisableText", 1.5f);
            hasPlayed = true;
            goldLock = false;
        }
        else if (enableText && goldLock && Keys.goldKey == true && hasPlayed == false)
        {
            // Open the drawer
            GetComponent<Canvas>().enabled = true;
            keyText.text = "Opened!";
            hasPlayed = true;
            Invoke("DisableText", 1.5f);
            goldLock = false;
        }
    }
    public void DisableText()
    {
        enableText = false;
        GetComponent<Canvas>().enabled = false;
        hasPlayed = false; 
    }
}
