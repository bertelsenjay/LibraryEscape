using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookUI : MonoBehaviour
{
    public static bool isBook; 
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (isBook == true)
        {
            GetComponent<Canvas>().enabled = true;
            Time.timeScale = 0;
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                GetComponent<Canvas>().enabled = false;
                Time.timeScale = 1;
                isBook = false;
            }
        }
    }
}
