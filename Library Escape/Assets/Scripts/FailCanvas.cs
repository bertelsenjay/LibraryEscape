using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FailCanvas : MonoBehaviour
{
    public static bool enabledCanvas = false;
    public static bool enabledFibonacciCanvas = false;
    public TextMeshProUGUI failText;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Canvas>().enabled = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (enabledCanvas)
        {
            enabledCanvas = false;
            GetComponent<Canvas>().enabled = true;
            Invoke("DisableCanvas", 1f);
            failText.text = "Failed, wait 15 seconds to try again";
        }
        if (enabledFibonacciCanvas)
        {
            enabledFibonacciCanvas = false;
            GetComponent<Canvas>().enabled = true;
            Invoke("DisableCanvas", 1f);
            failText.text = "Failed, try agian";
        }
    }
    void DisableCanvas()
    {
        
        GetComponent<Canvas>().enabled = false;
        
        Debug.Log("Canvas Disabled");
    }
}
