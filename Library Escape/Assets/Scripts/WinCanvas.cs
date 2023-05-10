using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinCanvas : MonoBehaviour
{
    public static bool bookPuzzleWin;
    public static bool statuePuzzleWin;
    public static bool fibbonacciPuzzleWin;
    public static bool colorPuzzleWin;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (bookPuzzleWin == true)
        {
            GetComponent<Canvas>().enabled = true;
            
            Invoke("DisableCanvas", 3f);
            bookPuzzleWin = false;
            
        }
        else if (statuePuzzleWin == true)
        {
            GetComponent<Canvas>().enabled = true;
            //winText.text += "Code: 5579";
            Invoke("DisableCanvas", 3f);
            statuePuzzleWin = false; 
        }
        else if (fibbonacciPuzzleWin == true)
        {
            GetComponent<Canvas>().enabled = true;
            Invoke("DisableCanvas", 3f);
            fibbonacciPuzzleWin = false;
        }
        else if (colorPuzzleWin == true)
        {
            GetComponent<Canvas>().enabled = true;
            Invoke("DisableCanvas", 3f);
            colorPuzzleWin = false; 
        }
    }
    void DisableCanvas()
    {
        GetComponent<Canvas>().enabled = false; 
    }
}
