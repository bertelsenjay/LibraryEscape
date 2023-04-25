using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailCanvas : MonoBehaviour
{
    public static bool enabledCanvas = false;
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
            GetComponent<Canvas>().enabled = true;
            Invoke("DisableCanvas", 1f);
        }
    }
    void DisableCanvas()
    {
        GetComponent<Canvas>().enabled = false;
        enabledCanvas = false; 
    }
}
