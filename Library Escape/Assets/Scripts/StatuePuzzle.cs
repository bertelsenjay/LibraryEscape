using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatuePuzzle : MonoBehaviour
{
    public static bool isHoldingStatueOne = false;
    public static bool isHoldingStatueTwo = false;
    public static bool isHoldingStatueThree = false;
    public static bool isHoldingStatueFour = false;



    public static int statueOnFirst = 0;
    public static int statueOnSecond = 0;
    public static int statueOnThird = 0;
    public static int statueOnFourth = 0;
    public static bool puzzleComplete = false;

    // Update is called once per frame
    void Update()
    {
        if(statueOnFirst != 0 && statueOnSecond != 0 && statueOnThird != 0 && statueOnFourth != 0)
        {
            if (statueOnFirst == 2 && statueOnSecond == 3 && statueOnThird == 1 && statueOnFourth == 4 && puzzleComplete == false)
            {
                Debug.Log("Puzzle Completed");
                puzzleComplete = true;
            }
            else
            {
                PlayerPickupDrop.statueFail = true;
                statueOnFirst = 0;
                statueOnSecond = 0;
                statueOnThird = 0;
                statueOnFourth = 0;

            }
        }
        
        
    }
    void ResetStatuePosition()
    {

    }
}
