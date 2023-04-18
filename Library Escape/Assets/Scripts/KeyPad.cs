using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 
public class KeyPad : MonoBehaviour
{
    [SerializeField] private Text Ans;
    public string answer1 = "1234";
    public string answer2;
    public string answer3;
    public string answer4;
    public string answer5; 
    // Update is called once per frame
    public void Number(int number)
    {
        Ans.text += number.ToString();
    }
    public void Enter()
    {
        if (Ans.text == answer1)
        {
            Ans.text = "Right!";
            Invoke("Reset", 1f);
        }
        else
        {
            Ans.text = "Wrong!";
            Invoke("Reset", 1f);
        }
    }
    void Reset()
    {
        Ans.text = "";
    }
}
