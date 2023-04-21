using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatuePuzzle : MonoBehaviour
{
    public static bool isHoldingStatueOne = false;
    public static bool isHoldingStatueTwo = false;
    public static bool isHoldingStatueThree = false;
    public static bool isHoldingStatueFour = false;

    public static int statueOnFirst;
    public static int statueOnSecond;
    public static int statueOnThird;
    public static int statueOnFourth;
    public static bool puzzleComplete = false;

    // Update is called once per frame
    void Update()
    {
        /*if (statueOnFirst == 2 && statueOnSecond == 3 && statueOnThird == 1 && puzzleComplete == false)
        {
            Debug.Log("Puzzle Completed");
            puzzleComplete = true;
        }*/
    }
}
