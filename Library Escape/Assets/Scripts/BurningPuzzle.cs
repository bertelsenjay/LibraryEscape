using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurningPuzzle : MonoBehaviour
{
    public static bool isHoldingBookOne = false;
    public static bool isHoldingBookTwo = false;
    public static bool isHoldingBookThree = false;
    public static bool isHoldingBookFour = false;
    public static bool isHoldingBookFive = false;
    public static bool isHoldingBookSix = false;

    public static bool isBookOnePlaced = false;
    public static bool isBookTwoPlaced = false;
    public static bool isBookThreePlaced = false;
    public static bool isBookFourPlaced = false;
    public static bool isBookFivePlaced = false;
    public static bool isBookSixPlaced = false; 

    public static bool puzzleComplete = false;
    public GameObject burningPuzzleCover;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (puzzleComplete == true)
        {
            Destroy(burningPuzzleCover);
        }
    }
}
