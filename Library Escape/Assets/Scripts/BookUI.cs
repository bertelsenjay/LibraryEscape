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
    public static bool bookOneOpen;
    public static bool bookTwoOpen;
    public static bool bookThreeOpen;
    public static bool bookFourOpen;
    public static bool bookFiveOpen;
    public static bool bookSixOpen;

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
                    GetComponent<Canvas>().enabled = false;
                    Time.timeScale = 1;
                    isBook = false;
                    bookOneOpen = false;
                }
            }
            else if (bookTwoOpen)
            {
                bookText.text = bookTwoText;
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    GetComponent<Canvas>().enabled = false;
                    Time.timeScale = 1;
                    isBook = false;
                    bookTwoOpen = false;
                }
            }
            else if (bookThreeOpen)
            {
                bookText.text = bookThreeText;
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    GetComponent<Canvas>().enabled = false;
                    Time.timeScale = 1;
                    isBook = false;
                    bookThreeOpen = false;
                }
            }
            else if (bookFourOpen)
            {
                bookText.text = bookFourText;
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    GetComponent<Canvas>().enabled = false;
                    Time.timeScale = 1;
                    isBook = false;
                    bookFourOpen = false;
                }
            }
            else if (bookFiveOpen)
            {
                bookText.text = bookFiveText;
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    GetComponent<Canvas>().enabled = false;
                    Time.timeScale = 1;
                    isBook = false;
                    bookFiveOpen = false;
                }
            }
            else if (bookSixOpen)
            {
                bookText.text = bookSixText;
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    GetComponent<Canvas>().enabled = false;
                    Time.timeScale = 1;
                    isBook = false;
                    bookSixOpen = false;
                }
            }
        }
    }
}
