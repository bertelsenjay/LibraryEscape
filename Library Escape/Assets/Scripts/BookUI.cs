using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class BookUI : MonoBehaviour
{
    public static bool isBook;
    public static string text;
    public TextMeshProUGUI bookText;
    public string bookOneText;
    public string bookTwoText;
    public string bookThreeText;
    public string bookFourText;
    public string bookFiveText;
    public string bookSixText;
    public static bool bookOneOpen = false;
    public static bool bookTwoOpen = false;
    public static bool bookThreeOpen = false;
    public static bool bookFourOpen = false;
    public static bool bookFiveOpen = false;
    public static bool bookSixOpen = false;

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
            if (bookOneOpen)
            {
                bookText.text = bookOneText;
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    isBook = false;
                    bookOneOpen = false;
                    GetComponent<Canvas>().enabled = false;
                    //Time.timeScale = 1;
                    
                }
            }
            else if (bookTwoOpen)
            {
                bookText.text = bookTwoText;
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    isBook = false;
                    bookTwoOpen = false;
                    GetComponent<Canvas>().enabled = false;
                    //Time.timeScale = 1;
                    
                }
            }
            else if (bookThreeOpen)
            {
                bookText.text = bookThreeText;
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    isBook = false;
                    bookThreeOpen = false;
                    GetComponent<Canvas>().enabled = false;
                    //Time.timeScale = 1;
                    
                }
            }
            else if (bookFourOpen)
            {
                bookText.text = bookFourText;
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    isBook = false;
                    bookFourOpen = false;
                    GetComponent<Canvas>().enabled = false;
                    //Time.timeScale = 1;
                    
                }
            }
            else if (bookFiveOpen)
            {
                bookText.text = bookFiveText;
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    isBook = false;
                    bookFiveOpen = false;
                    GetComponent<Canvas>().enabled = false;
                    //Time.timeScale = 1;
                    
                }
            }
            else if (bookSixOpen)
            {
                bookText.text = bookSixText;
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    isBook = false;
                    bookSixOpen = false;
                    GetComponent<Canvas>().enabled = false;
                    //Time.timeScale = 1;
                    
                }
            }
        }
    }
}
