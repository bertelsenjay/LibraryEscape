using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keys : MonoBehaviour
{
    public static bool bronzeKey = false;
    public static bool silverKey = false;
    public static bool goldKey = false;

    public Image bronzeKeyImage;
    public Image silverKeyImage;
    public Image goldKeyImage;
    // Start is called before the first frame update
    void Start()
    {
        bronzeKeyImage.enabled = false;
        silverKeyImage.enabled = false;
        goldKeyImage.enabled = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (bronzeKey)
        {
            bronzeKeyImage.enabled = true;
        }
        if (silverKey)
        {
            silverKeyImage.enabled = true;
        }
        if (goldKey)
        {
            goldKeyImage.enabled = true; 
        }
    }
}
