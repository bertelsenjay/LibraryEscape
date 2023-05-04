using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public static bool answer1Correct = false;
    public static bool answer2Correct = false;
    public static bool answer3Correct = false;
    public static bool answer4Correct = false;
    public static bool answer5Correct = false;
    public static int totalCorrect = 0;
    int firstInt;
    int secondInt;
    int thirdInt;
    int fourthInt;
    int fifthInt;
    public static bool firstBool;
    public static bool secondBool;
    public static bool thirdBool;
    public static bool fourthBool;
    public static bool fifthBool;

    public GameObject Door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (totalCorrect >= 3)
        {
            Destroy(Door);
        }
        if (totalCorrect >= 5)
        {
            //Give Completion Bonus
        }*/
        if (firstBool)
        {
            firstInt = 1;
        }
        if (secondBool)
        {
            secondInt = 1;
        }
        if (thirdBool)
        {
            thirdInt = 1;
        }
        if (fourthBool)
        {
            fourthInt = 1;
        }
        if (fifthBool)
        {
            fifthInt = 1; 
        }

        if ( (firstInt + secondInt + thirdInt + fourthInt + fifthInt) >= 3)
        {
            Destroy(Door);
        }

        if ( (firstInt + secondInt + thirdInt + fourthInt + fifthInt) >= 5 )
        {
            //Completion bonus
        }
    }
}
