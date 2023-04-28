using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 
public class KeyPad : MonoBehaviour
{
    [SerializeField] public Text Ans;
    public string answer1 = "1234";
    public string answer2;
    public string answer3;
    public string answer4;
    public string answer5;
    bool answer1Correct = false;
    bool answer2Correct = false;
    bool answer3Correct = false;
    bool answer4Correct = false;
    bool answer5Correct = false;
    // Update is called once per frame
    public void Number(int number)
    {
        Ans.text += number.ToString();
    }
    public void Enter()
    {
        if (Ans.text == answer1)
        {

            if (answer1Correct == false)
            {
                DoorOpen.totalCorrect++;
                Ans.text = "Right!";
                Invoke("Reset", 1f);
                answer1Correct = true;
            }
            else
            {
                Ans.text = "Used";
                Invoke("Reset", 1f);
            }
        }
        else if (Ans.text == answer2)
        {
            if (answer2Correct == false)
            {
                DoorOpen.totalCorrect++;
                Ans.text = "Right!";
                Invoke("Reset", 1f);
                answer2Correct = true;
            }
            else
            {
                Ans.text = "Used";
                Invoke("Reset", 1f);
            }
        }
        else if (Ans.text == answer3)
        {
            if (answer3Correct == false)
            {
                DoorOpen.totalCorrect++;
                Ans.text = "Right!";
                Invoke("Reset", 1f);
                answer3Correct = true;
            }
            else
            {
                Ans.text = "Used";
                Invoke("Reset", 1f);
            }
        }
        else if (Ans.text == answer4)
        {
            if (answer4Correct == false)
            {
                DoorOpen.totalCorrect++;
                Ans.text = "Right!";
                Invoke("Reset", 1f);
                answer4Correct = true;
            }
            else
            {
                Ans.text = "Used";
                Invoke("Reset", 1f);
            }
        }
        else if (Ans.text == answer5)
        {
            if (answer5Correct == false)
            {
                DoorOpen.totalCorrect++;
                Ans.text = "Right!";
                Invoke("Reset", 1f);
                answer5Correct = true;
            }
            else
            {
                Ans.text = "Used";
                Invoke("Reset", 1f);
            }
        }
        else
        {
            Ans.text = "Wrong!";
            Invoke("DisableKeypad", 2.5f);
        }
    }
    public void ResetPuzzle()
    {
        Ans.text = "";
    }
    void DisableKeypad()
    {
        KeypadCanvas.autoDisable = true;


    }
}
