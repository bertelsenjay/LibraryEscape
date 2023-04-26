using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class PlayerPickupDrop : MonoBehaviour
{
    [SerializeField] private Transform playerCameraTransform;
    [SerializeField] private LayerMask pickupLayerMask;
    public float pickupDistance = 2.0f;
    public GameObject statue1;
    public GameObject statue2;
    public GameObject statue3;
    public GameObject statue4;
    public GameObject bookBurn1;
    public GameObject bookBurn2;
    public GameObject bookBurn3;
    public GameObject bookBurn4;
    public GameObject bookBurn5;
    public GameObject bookBurn6;
    public Transform book1Trans;
    public Transform book2Trans;
    public Transform book3Trans;
    public Transform book4Trans;
    public Transform book5Trans;
    public Transform book6Trans;
    public Transform plate1;
    public Transform plate2;
    public Transform plate3;
    public Transform plate4; 
    public Transform extraPlate;
    public TextMeshProUGUI failText;
    public Transform statue1ResetPos;
    public Transform statue2ResetPos;
    public Transform statue3ResetPos;
    public Transform statue4ResetPos;
    GameObject statue1Clone;
    GameObject statue2Clone;
    GameObject statue3Clone;
    GameObject statue4Clone;
    bool firstAttempt;
    public int totalNumber = 0;
    bool isMultiply; 
    int booksPlaced = 0;
    public static bool statueFail; 
    // Start is called before the first frame update
    private void Start()
    {
        Instantiate(bookBurn1, book1Trans.position, Quaternion.identity);
        Instantiate(bookBurn2, book2Trans.position, Quaternion.identity);
        Instantiate(bookBurn3, book3Trans.position, Quaternion.identity);
        Instantiate(bookBurn4, book4Trans.position, Quaternion.identity);
        Instantiate(bookBurn5, book5Trans.position, Quaternion.identity);
        Instantiate(bookBurn6, book6Trans.position, Quaternion.identity);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit raycastHit, pickupDistance, pickupLayerMask))
            {
                if (raycastHit.transform.TryGetComponent(out ObjectGrabbable objectGrabbable))
                {
                    
                    if (objectGrabbable.name == "Door")
                    {
                        KeypadCanvas.keypadEnabled = true;
                        
                    }
                    else if (objectGrabbable.name == "BronzeKey")
                    {
                        Destroy(objectGrabbable.gameObject);
                        Keys.bronzeKey = true;
                    }
                    else if (objectGrabbable.name == "SilverKey")
                    {
                        Destroy(objectGrabbable.gameObject);
                        Keys.silverKey = true;
                    }
                    else if (objectGrabbable.name == "GoldKey")
                    {
                        Destroy(objectGrabbable.gameObject);
                        Keys.goldKey = true;
                    }
                    else if (objectGrabbable.name == "Statue1" || objectGrabbable.name == "Statue1(Clone)" && StatuePuzzle.puzzleComplete == false)
                    {
                        if (StatuePuzzle.isHoldingStatueTwo == false && StatuePuzzle.isHoldingStatueThree == false && StatuePuzzle.isHoldingStatueFour == false)
                        {
                            Destroy(objectGrabbable.gameObject);
                            StatuePuzzle.isHoldingStatueOne = true; 
                        }
                        
                    }
                    else if (objectGrabbable.name == "Statue2" || objectGrabbable.name == "Statue2(Clone)" && StatuePuzzle.puzzleComplete == false)
                    {
                        if (StatuePuzzle.isHoldingStatueOne == false && StatuePuzzle.isHoldingStatueThree == false && StatuePuzzle.isHoldingStatueFour == false)
                        {
                            Destroy(objectGrabbable.gameObject);
                            StatuePuzzle.isHoldingStatueTwo = true;
                        }
                    }
                    else if (objectGrabbable.name == "Statue3" || objectGrabbable.name == "Statue3(Clone)" && StatuePuzzle.puzzleComplete == false)
                    {
                        if (StatuePuzzle.isHoldingStatueTwo == false && StatuePuzzle.isHoldingStatueOne == false && StatuePuzzle.isHoldingStatueFour == false)
                        {
                            Destroy(objectGrabbable.gameObject);
                            StatuePuzzle.isHoldingStatueThree = true;
                        }
                    }
                    else if (objectGrabbable.name == "Statue4" || objectGrabbable.name == "Statue4(Clone)" && StatuePuzzle.puzzleComplete == false)
                    {
                        if (StatuePuzzle.isHoldingStatueTwo == false && StatuePuzzle.isHoldingStatueOne == false && StatuePuzzle.isHoldingStatueThree == false)
                        {
                            Destroy(objectGrabbable.gameObject);
                            StatuePuzzle.isHoldingStatueFour = true;
                        }
                    }
                    else if (objectGrabbable.name == "Book1" || objectGrabbable.name == "Book1(Clone)" && BurningPuzzle.puzzleComplete == false)
                    {
                        if (BurningPuzzle.isHoldingBookTwo == false && BurningPuzzle.isHoldingBookThree == false && BurningPuzzle.isHoldingBookFour == false && BurningPuzzle.isHoldingBookFive == false && BurningPuzzle.isHoldingBookSix == false)
                        {
                            Destroy(objectGrabbable.gameObject);
                            BurningPuzzle.isHoldingBookOne = true;
                        }
                    }
                    else if (objectGrabbable.name == "Book2" || objectGrabbable.name == "Book2(Clone)" && BurningPuzzle.puzzleComplete == false)
                    {
                        if (BurningPuzzle.isHoldingBookOne == false && BurningPuzzle.isHoldingBookThree == false && BurningPuzzle.isHoldingBookFour == false && BurningPuzzle.isHoldingBookFive == false && BurningPuzzle.isHoldingBookSix == false)
                        {
                            Destroy(objectGrabbable.gameObject);
                            BurningPuzzle.isHoldingBookTwo = true;
                        }
                    }
                    else if (objectGrabbable.name == "Book3" || objectGrabbable.name == "Book3(Clone)" && BurningPuzzle.puzzleComplete == false)
                    {
                        if (BurningPuzzle.isHoldingBookTwo == false && BurningPuzzle.isHoldingBookOne == false && BurningPuzzle.isHoldingBookFour == false && BurningPuzzle.isHoldingBookFive == false && BurningPuzzle.isHoldingBookSix == false)
                        {
                            Destroy(objectGrabbable.gameObject);
                            BurningPuzzle.isHoldingBookThree = true;
                        }
                    }
                    else if (objectGrabbable.name == "Book4" || objectGrabbable.name == "Book4(Clone)" && BurningPuzzle.puzzleComplete == false)
                    {
                        if (BurningPuzzle.isHoldingBookTwo == false && BurningPuzzle.isHoldingBookThree == false && BurningPuzzle.isHoldingBookOne == false && BurningPuzzle.isHoldingBookFive == false && BurningPuzzle.isHoldingBookSix == false)
                        {
                            Destroy(objectGrabbable.gameObject);
                            BurningPuzzle.isHoldingBookFour = true;
                        }
                    }
                    else if (objectGrabbable.name == "Book5" || objectGrabbable.name == "Book5(Clone)" && BurningPuzzle.puzzleComplete == false)
                    {
                        if (BurningPuzzle.isHoldingBookTwo == false && BurningPuzzle.isHoldingBookThree == false && BurningPuzzle.isHoldingBookFour == false && BurningPuzzle.isHoldingBookOne == false && BurningPuzzle.isHoldingBookSix == false)
                        {
                            Destroy(objectGrabbable.gameObject);
                            BurningPuzzle.isHoldingBookFive = true;
                        }
                    }
                    else if (objectGrabbable.name == "Book6" || objectGrabbable.name == "Book6(Clone)" && BurningPuzzle.puzzleComplete == false)
                    {
                        if (BurningPuzzle.isHoldingBookTwo == false && BurningPuzzle.isHoldingBookThree == false && BurningPuzzle.isHoldingBookFour == false && BurningPuzzle.isHoldingBookFive == false && BurningPuzzle.isHoldingBookOne == false)
                        {
                            Destroy(objectGrabbable.gameObject);
                            BurningPuzzle.isHoldingBookSix = true;
                        }
                    }
                }
                else if (raycastHit.transform.TryGetComponent(out ObjectReadable objectReadable))
                {
                    if (objectReadable.name == "Book")
                    {
                        BookUI.isBook = true; 
                    }
                    /*switch (objectReadable.name)
                    {

                    }*/
                }
                else if (raycastHit.transform.TryGetComponent(out LockedObject lockedObject))
                {
                    LockedText.enableText = true;
                    if (lockedObject.name == "BronzeLocked")
                    {
                        LockedText.bronzeLock = true; 
                    }
                    else if (lockedObject.name == "SilverLocked")
                    {
                        LockedText.silverLock = true; 
                    }
                    else if (lockedObject.name == "GoldLocked")
                    {
                        LockedText.goldLock = true; 
                    }
                    
                }
                else if (raycastHit.transform.TryGetComponent(out ObjectPlaceable objectPlaceable))
                {
                    if (objectPlaceable.name == "PressurePlate1" && StatuePuzzle.puzzleComplete == false)
                    {
                        Debug.Log("1 Placed");
                        if (StatuePuzzle.isHoldingStatueOne == true)
                        {
                            StatuePuzzle.isHoldingStatueOne = false;
                            Instantiate(statue1, plate1.position, Quaternion.identity);
                            StatuePuzzle.statueOnFirst = 1;
                            statue1Clone = GameObject.Find("Statue1(Clone)");
                        }
                        else if (StatuePuzzle.isHoldingStatueTwo == true)
                        {
                            StatuePuzzle.isHoldingStatueTwo = false;
                            Instantiate(statue2, plate1.position, Quaternion.identity);
                            StatuePuzzle.statueOnFirst = 2;
                            statue2Clone = GameObject.Find("Statue2(Clone)");
                        }
                        else if (StatuePuzzle.isHoldingStatueThree == true)
                        {
                            StatuePuzzle.isHoldingStatueThree = false;
                            Instantiate(statue3, plate1.position, Quaternion.identity);
                            StatuePuzzle.statueOnFirst = 3;
                            statue3Clone = GameObject.Find("Statue3(Clone)");
                        }
                        else if (StatuePuzzle.isHoldingStatueFour == true)
                        {
                            StatuePuzzle.isHoldingStatueFour = false;
                            Instantiate(statue4, plate1.position, Quaternion.identity);
                            StatuePuzzle.statueOnFirst = 4;
                            statue4Clone = GameObject.Find("Statue4(Clone)");
                        }
                    }
                    else if (objectPlaceable.name == "PressurePlate2" && StatuePuzzle.puzzleComplete == false)
                    {
                        Debug.Log("2 Placed");
                        if (StatuePuzzle.isHoldingStatueOne == true)
                        {
                            StatuePuzzle.isHoldingStatueOne = false;
                            Instantiate(statue1, plate2.position, Quaternion.identity);
                            StatuePuzzle.statueOnSecond = 1;
                            statue1Clone = GameObject.Find("Statue1(Clone)");
                        }
                        else if (StatuePuzzle.isHoldingStatueTwo == true)
                        {
                            StatuePuzzle.isHoldingStatueTwo = false;
                            Instantiate(statue2, plate2.position, Quaternion.identity);
                            StatuePuzzle.statueOnSecond = 2;
                            statue2Clone = GameObject.Find("Statue2(Clone)");
                        }
                        else if (StatuePuzzle.isHoldingStatueThree == true)
                        {
                            StatuePuzzle.isHoldingStatueThree = false;
                            Instantiate(statue3, plate2.position, Quaternion.identity);
                            StatuePuzzle.statueOnSecond = 3;
                            statue3Clone = GameObject.Find("Statue3(Clone)");
                        }
                        else if (StatuePuzzle.isHoldingStatueFour == true)
                        {
                            StatuePuzzle.isHoldingStatueFour = false;
                            Instantiate(statue4, plate2.position, Quaternion.identity);
                            StatuePuzzle.statueOnSecond = 4;
                            statue4Clone = GameObject.Find("Statue4(Clone)");
                        }
                    }
                    else if (objectPlaceable.name == "PressurePlate3" && StatuePuzzle.puzzleComplete == false)
                    {
                        Debug.Log("3 Placed");
                        if (StatuePuzzle.isHoldingStatueOne == true)
                        {
                            StatuePuzzle.isHoldingStatueOne = false;
                            Instantiate(statue1, plate3.position, Quaternion.identity);
                            StatuePuzzle.statueOnThird = 1;
                            statue1Clone = GameObject.Find("Statue1(Clone)");
                        }
                        else if (StatuePuzzle.isHoldingStatueTwo == true)
                        {
                            StatuePuzzle.isHoldingStatueTwo = false;
                            Instantiate(statue2, plate3.position, Quaternion.identity);
                            StatuePuzzle.statueOnThird = 2;
                            statue2Clone = GameObject.Find("Statue2(Clone)");
                        }
                        else if (StatuePuzzle.isHoldingStatueThree == true)
                        {
                            StatuePuzzle.isHoldingStatueThree = false;
                            Instantiate(statue3, plate3.position, Quaternion.identity);
                            StatuePuzzle.statueOnThird = 3;
                            statue3Clone = GameObject.Find("Statue3(Clone)");
                        }
                        else if (StatuePuzzle.isHoldingStatueFour == true)
                        {
                            StatuePuzzle.isHoldingStatueFour = false;
                            Instantiate(statue4, plate3.position, Quaternion.identity);
                            StatuePuzzle.statueOnThird = 4;
                            statue4Clone = GameObject.Find("Statue4(Clone)");
                        }
                    }
                    else if (objectPlaceable.name == "PressurePlate4" && StatuePuzzle.puzzleComplete == false)
                    {
                        Debug.Log("1 Placed");
                        if (StatuePuzzle.isHoldingStatueOne == true)
                        {
                            StatuePuzzle.isHoldingStatueOne = false;
                            Instantiate(statue1, plate4.position, Quaternion.identity);
                            StatuePuzzle.statueOnFourth = 1;
                            statue1Clone = GameObject.Find("Statue1(Clone)");
                        }
                        else if (StatuePuzzle.isHoldingStatueTwo == true)
                        {
                            StatuePuzzle.isHoldingStatueTwo = false;
                            Instantiate(statue2, plate4.position, Quaternion.identity);
                            StatuePuzzle.statueOnFourth = 2;
                            statue2Clone = GameObject.Find("Statue2(Clone)");
                        }
                        else if (StatuePuzzle.isHoldingStatueThree == true)
                        {
                            StatuePuzzle.isHoldingStatueThree = false;
                            Instantiate(statue3, plate4.position, Quaternion.identity);
                            StatuePuzzle.statueOnFourth = 3;
                            statue3Clone = GameObject.Find("Statue3(Clone)");
                        }
                        else if (StatuePuzzle.isHoldingStatueFour == true)
                        {
                            StatuePuzzle.isHoldingStatueFour = false;
                            Instantiate(statue4, plate4.position, Quaternion.identity);
                            StatuePuzzle.statueOnFourth = 4;
                            statue4Clone = GameObject.Find("Statue4(Clone)");
                        }
                    }
                    else if (objectPlaceable.name == "ExtraPlate")
                    {
                        Debug.Log("3 Placed");
                        if (StatuePuzzle.isHoldingStatueOne == true)
                        {
                            StatuePuzzle.isHoldingStatueOne = false;
                            Instantiate(statue1, extraPlate.position, Quaternion.identity);
                            statue1Clone = GameObject.Find("Statue1(Clone)");
                        }
                        else if (StatuePuzzle.isHoldingStatueTwo == true)
                        {
                            StatuePuzzle.isHoldingStatueTwo = false;
                            Instantiate(statue2, extraPlate.position, Quaternion.identity);
                            statue2Clone = GameObject.Find("Statue2(Clone)");
                        }
                        else if (StatuePuzzle.isHoldingStatueThree == true)
                        {
                            StatuePuzzle.isHoldingStatueThree = false;
                            Instantiate(statue3, extraPlate.position, Quaternion.identity);
                            statue3Clone = GameObject.Find("Statue3(Clone)");
                        }
                        else if (StatuePuzzle.isHoldingStatueFour == true)
                        {
                            StatuePuzzle.isHoldingStatueFour = false;
                            Instantiate(statue4, extraPlate.position, Quaternion.identity);
                            statue4Clone = GameObject.Find("Statue4(Clone)");
                        }
                    }
                    
          
                    else if (objectPlaceable.name == "Fireplace" && BurningPuzzle.puzzleComplete == false)
                    {
                        
                        if (booksPlaced < 3)
                        {
                            if(BurningPuzzle.isHoldingBookOne == true)
                            {
                                BurningPuzzle.isHoldingBookOne = false; 
                                booksPlaced++;
                                BurningPuzzle.isBookOnePlaced = true;
                                Debug.Log("Successfully Burned1");
                            }
                            else if (BurningPuzzle.isHoldingBookTwo == true)
                            {
                                BurningPuzzle.isHoldingBookTwo = false;
                                booksPlaced++;
                                BurningPuzzle.isBookTwoPlaced = true;
                                Debug.Log("Successfully Burned2");
                            }
                            else if (BurningPuzzle.isHoldingBookThree == true)
                            {
                                BurningPuzzle.isHoldingBookThree = false;
                                booksPlaced++;
                                BurningPuzzle.isBookThreePlaced = true;
                                Debug.Log("Successfully Burned3");
                            }
                            else if (BurningPuzzle.isHoldingBookFour == true)
                            {
                                BurningPuzzle.isHoldingBookFour = false;
                                booksPlaced++;
                                BurningPuzzle.isBookFourPlaced = true;
                                Debug.Log("Successfully Burned4");
                            }
                            else if (BurningPuzzle.isHoldingBookFive == true)
                            {
                                BurningPuzzle.isHoldingBookFive = false;
                                booksPlaced++;
                                BurningPuzzle.isBookFivePlaced = true;
                                Debug.Log("Successfully Burned5");
                            }
                            else if (BurningPuzzle.isHoldingBookSix == true)
                            {
                                BurningPuzzle.isHoldingBookSix = false;
                                booksPlaced++;
                                BurningPuzzle.isBookSixPlaced = true;
                                Debug.Log("Successfully Burned6");
                            }
                        }
                        
                    }
                    if (booksPlaced >= 3)
                    {
                        //Checks if it is the correct books
                        if (BurningPuzzle.isBookOnePlaced == true && BurningPuzzle.isBookTwoPlaced == true && BurningPuzzle.isBookThreePlaced == true && BurningPuzzle.puzzleComplete == false)
                        {
                            Debug.Log("Puzzle Completed!");
                            Destroy(bookBurn4);
                            Destroy(bookBurn5);
                            Destroy(bookBurn6);
                            BurningPuzzle.puzzleComplete = true; 

                        }
                        else
                        {
                            FailCanvas.enabledCanvas = true; 
                            Invoke("ResetBurnPuzzle", 15f);
                            
                        }
                    }
                    

                }
                else if (raycastHit.transform.TryGetComponent(out ObjectButton objectButton))
                {
                    
                    
                    if (objectButton.name == "Button3" && FibbonacciPuzzle.secondPuzzleAnswered == false && FibbonacciPuzzle.thirdPuzzleAnswered == false && FibbonacciPuzzle.firstPuzzleAnswered == false)
                    {
                        FibbonacciPuzzle.firstPuzzleAnswered = true;
                        Debug.Log("First Puzzle Done");
                        firstAttempt = true; 

                    }
                    else if(objectButton.name != "Button3" && FibbonacciPuzzle.firstPuzzleAnswered == false)
                    {
                        FailCanvas.enabledCanvas = true;
                    }
                    
                    if (FibbonacciPuzzle.firstPuzzleAnswered == true && FibbonacciPuzzle.thirdPuzzleAnswered == false && FibbonacciPuzzle.secondPuzzleAnswered == false)
                    {
                        
                        if(objectButton.name == "Button3" && totalNumber == 0 )
                        {
                            totalNumber += 3;
                            Debug.Log("3 successful");
                            if(firstAttempt == true)
                            {
                                totalNumber = 0;
                                firstAttempt = false;
                            }
                        }
                        else if(objectButton.name == "Button7" && totalNumber == 0 )
                        {
                            totalNumber += 7;
                            Debug.Log("7 successful");
                        }
                        else if (objectButton.name != "Button3" && objectButton.name != "Button7" && totalNumber != 0)
                        {
                            totalNumber = 0;
                            FailCanvas.enabledCanvas = true;
                        }
                        else if (objectButton.name == "Button2")
                        {
                            totalNumber = 0;
                            FailCanvas.enabledCanvas = true;
                        }
                        else if (objectButton.name == "Button4")
                        {
                            totalNumber = 0;
                            FailCanvas.enabledCanvas = true;
                        }
                        else if (objectButton.name == "Button6")
                        {
                            totalNumber = 0;
                            FailCanvas.enabledCanvas = true;
                        }
                        else if (objectButton.name == "Button10")
                        {
                            totalNumber = 0;
                            FailCanvas.enabledCanvas = true;
                        }
                        else if (objectButton.name == "Button15")
                        {
                            totalNumber = 0;
                            FailCanvas.enabledCanvas = true;
                        }

                        /*if (objectButton.name == "ButtonMultiply" && totalNumber == 3 || totalNumber == 7 )
                        {
                            if (isMultiply == false)
                            {
                                isMultiply = true;
                                Debug.Log("Multiply Successful");
                            }
                            
                            
                        }*/
                        
                        if (objectButton.name == "Button3" && totalNumber == 7) 
                        {
                            FibbonacciPuzzle.secondPuzzleAnswered = true;
                            Debug.Log("Puzzle 2 Done");
                            totalNumber = 0;
                        }
                        else if (objectButton.name == "Button7" && totalNumber == 3)
                        {
                            FibbonacciPuzzle.secondPuzzleAnswered = true;
                            Debug.Log("Puzzle 2 Done");
                            totalNumber = 0;
                        }
                        else if (totalNumber != 3 && totalNumber != 7 && totalNumber != 0)
                        {
                            FailCanvas.enabledCanvas = true;
                        }
                        
                    }
                    if (FibbonacciPuzzle.firstPuzzleAnswered == true && FibbonacciPuzzle.secondPuzzleAnswered == true && FibbonacciPuzzle.thirdPuzzleAnswered == false)
                    {

                    }
                }
            }
            
        }
        if (statueFail == true)
        {
            FailCanvas.enabledCanvas = true;
            statueFail = false;
            Invoke("ResetStatuePuzzle", 15f);
            
        }
    }
    void ResetBurnPuzzle()
    {
        booksPlaced = 0;
        BurningPuzzle.isBookOnePlaced = false;
        BurningPuzzle.isBookTwoPlaced = false;
        BurningPuzzle.isBookThreePlaced = false;
        BurningPuzzle.isBookFourPlaced = false;
        BurningPuzzle.isBookFivePlaced = false;
        BurningPuzzle.isBookSixPlaced = false;
        Destroy(bookBurn1);
        Destroy(bookBurn2);
        Destroy(bookBurn3);
        Destroy(bookBurn4);
        Destroy(bookBurn5);
        Destroy(bookBurn6);
        Instantiate(bookBurn1, book1Trans.position, Quaternion.identity);
        Instantiate(bookBurn2, book2Trans.position, Quaternion.identity);
        Instantiate(bookBurn3, book3Trans.position, Quaternion.identity);
        Instantiate(bookBurn4, book4Trans.position, Quaternion.identity);
        Instantiate(bookBurn5, book5Trans.position, Quaternion.identity);
        Instantiate(bookBurn6, book6Trans.position, Quaternion.identity);
    }
    void ResetStatuePuzzle()
    {
        statue1Clone.transform.position = statue1ResetPos.transform.position;
        statue2Clone.transform.position = statue2ResetPos.transform.position;
        statue3Clone.transform.position = statue3ResetPos.transform.position;
        statue4Clone.transform.position = statue4ResetPos.transform.position;
        /*Destroy(statue1Clone);
        Destroy(statue2Clone);
        Destroy(statue3Clone);
        Destroy(statue4Clone);*/
    }
}
