using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KeypadCanvas : MonoBehaviour
{
    public static bool keypadEnabled = false;
    public static bool autoDisable = false; 
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
                if (keypadEnabled == false)
                {
                    GetComponent<Canvas>().enabled = false;
                    Cursor.lockState = CursorLockMode.Locked;
                }
                
            }
            if (autoDisable == true)
            {
                GetComponent<Canvas>().enabled = false;
                Cursor.lockState = CursorLockMode.Locked;
                autoDisable = false;
            }
        }
    }
}
