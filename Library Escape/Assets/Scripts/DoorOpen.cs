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
    public GameObject Door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (totalCorrect >= 3)
        {
            Destroy(Door);
        }
    }
}
