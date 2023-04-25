using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KeypadCanvas : MonoBehaviour
{
    public static bool keypadEnabled = false;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (keypadEnabled)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
            GetComponent<Canvas>().enabled = true;
            Time.timeScale = 0;
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                keypadEnabled = false;
                Time.timeScale = 1;
                GetComponent<Canvas>().enabled = false;
            }
        }
    }
}
