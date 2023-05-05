using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using TMPro;

public class BinarySave : MonoBehaviour
{
    public static bool holdingItem;
    public int autoSaveDelay = 60;
    public float timer = 0;
    // game data to be saved
    GameData gameData;
    // name of file to write to
    string saveFile;
    CharacterController cc;
    
    FileStream dataStream;

    BinaryFormatter converter = new BinaryFormatter();
    private void Start()
    {
        LoadFile();
    }
    void Update()
    {
        timer = timer + 1 * Time.deltaTime;
        /*if (StatuePuzzle.isHoldingStatueOne)
        {
            PlayerPickupDrop.itemName = "Gorgon";
            Debug.Log("Item Name set");
            
        }
        else if (StatuePuzzle.isHoldingStatueTwo)
        {
            PlayerPickupDrop.itemName = "Knight";
        }
        else if (StatuePuzzle.isHoldingStatueThree)
        {
            PlayerPickupDrop.itemName = "Pirate";
        }
        else if (StatuePuzzle.isHoldingStatueFour)
        {
            PlayerPickupDrop.itemName = "Wizard";
        }
        else if (BurningPuzzle.isHoldingBookOne)
        {
            PlayerPickupDrop.itemName = "Book1";
        }
        else if (BurningPuzzle.isHoldingBookTwo)
        {
            PlayerPickupDrop.itemName = "Book2";
        }
        else if (BurningPuzzle.isHoldingBookThree)
        {
            PlayerPickupDrop.itemName = "Book3";
        }
        else if (BurningPuzzle.isHoldingBookFour)
        {
            PlayerPickupDrop.itemName = "Book4";
        }
        else if (BurningPuzzle.isHoldingBookFive)
        {
            PlayerPickupDrop.itemName = "Book5";
        }
        else if (BurningPuzzle.isHoldingBookSix)
        {
            PlayerPickupDrop.itemName = "Book6";
        }
        else
        {
            PlayerPickupDrop.itemName = "Nothing";
            Debug.Log("Else Activated");
        }*/

        if (Input.GetKeyDown(KeyCode.Alpha1) || timer >= autoSaveDelay)
        {
            /*if (gameObject.name == "CarryText")
            {
                
            }*/
            SaveFile();
            

            

            
        }
        if (MainMenu.doLoad == true)
        {
            
            
            

            
            

            

        }
        
    }

    void Awake()
    {
        saveFile = Application.persistentDataPath + "/" + gameObject.name + "gamedata.data";
        gameData = new GameData();
        cc = GetComponent<CharacterController>();
    }

    public void WriteFile()
    {
        //Create file stream to same file path
        dataStream = new FileStream(saveFile, FileMode.Create);

        //serialize data in file
        converter.Serialize(dataStream, gameData);

        //Close file
        dataStream.Close();
    }
    public void ReadFile()
    {
        //Does the file exist
        if(File.Exists(saveFile))
        {
            //Open File Stream
            dataStream = new FileStream(saveFile, FileMode.Open);

            //deserialize binary data
            gameData = converter.Deserialize(dataStream) as GameData;

            //Close file
            dataStream.Close();
            Debug.Log("FileRead");
            
        }
    }
    public void SaveFile()
    {
        /*if (gameObject.name == "CarryText")
            {
                
            }*/

        if (gameObject.name == "PlayerCapsule")
        {
            gameData.x = transform.position.x;
            gameData.y = transform.position.y;
            gameData.z = transform.position.z;
        }

        if (gameObject.name.Contains("Gorgon")) //== "Gorgon" || gameObject.name == "Gorgon(Clone)")
        {
            gameData.gorgonX = transform.position.x;
            gameData.gorgonY = transform.position.y;
            gameData.gorgonZ = transform.position.z;
            //if (StatuePuzzle.isHoldingStatueOne)
                Debug.Log(gameData.gorgonX);
            Debug.Log(gameData.gorgonY);
            Debug.Log(gameData.gorgonZ);
            Debug.Log("gorgon saved");
        }
        if (gameObject.name.Contains("Knight"))
        {
            gameData.knightX = transform.position.x;
            gameData.knightY = transform.position.y;
            gameData.knightZ = transform.position.z;
        }

        if (gameObject.name.Contains("Pirate"))
        {
            gameData.pirateX = transform.position.x;
            gameData.pirateY = transform.position.y;
            gameData.pirateZ = transform.position.z;
        }

        if (gameObject.name.Contains("Wizard"))
        {
            gameData.wizardX = transform.position.x;
            gameData.wizardY = transform.position.y;
            gameData.wizardZ = transform.position.z;
        }

        if (gameObject.name.Contains("Book1"))
        {
            gameData.book1X = transform.position.x;
            gameData.book1Y = transform.position.y;
            gameData.book1Z = transform.position.z;
        }

        if (gameObject.name.Contains("Book2"))
        {
            gameData.book2X = transform.position.x;
            gameData.book2Y = transform.position.y;
            gameData.book2Z = transform.position.z;
        }

        if (gameObject.name.Contains("Book3"))
        {
            gameData.book3X = transform.position.x;
            gameData.book3Y = transform.position.y;
            gameData.book3Z = transform.position.z;
        }

        if (gameObject.name.Contains("Book4"))
        {
            gameData.book4X = transform.position.x;
            gameData.book4Y = transform.position.y;
            gameData.book4Z = transform.position.z;
        }

        if (gameObject.name.Contains("Book5"))
        {
            gameData.book5X = transform.position.x;
            gameData.book5Y = transform.position.y;
            gameData.book5Z = transform.position.z;
        }

        if (gameObject.name.Contains("Book6"))
        {
            gameData.book6X = transform.position.x;
            gameData.book6Y = transform.position.y;
            gameData.book6Z = transform.position.z;
        }

        if (gameObject.name.Contains("Keypad"))
        {
            gameData.firstCode = KeyPad.answer1Correct;
            gameData.secondCode = KeyPad.answer2Correct;
            gameData.thirdCode = KeyPad.answer3Correct;
            gameData.fourthCode = KeyPad.answer4Correct;
            gameData.fifthCode = KeyPad.answer5Correct;
        }
        if (FibbonacciPuzzle.thirdPuzzleAnswered == true && FibbonacciPuzzle.firstPuzzleAnswered == true && FibbonacciPuzzle.secondPuzzleAnswered == true)
        {
            gameData.fibonacciPuzzle = true;
        }
        if (StatuePuzzle.puzzleComplete == true)
        {
            gameData.statuePuzzle = true;
        }
        if (BurningPuzzle.puzzleComplete == true)
        {
            gameData.bookPuzzle = true;
        }
        WriteFile();
        timer = 0;
        Debug.Log("Saved");
    }
    public void LoadFile()
    {
        Debug.Log("has ran at least 1 time");
        ReadFile();

        KeyPad.answer1Correct = gameData.firstCode;
        KeyPad.answer2Correct = gameData.secondCode;
        KeyPad.answer3Correct = gameData.thirdCode;
        KeyPad.answer4Correct = gameData.fourthCode;
        KeyPad.answer5Correct = gameData.fifthCode;
        if (gameData.fibonacciPuzzle == true)
        {
            FibbonacciPuzzle.firstPuzzleAnswered = true;
            FibbonacciPuzzle.secondPuzzleAnswered = true;
            FibbonacciPuzzle.thirdPuzzleAnswered = true;
        }
        if (gameData.statuePuzzle == true)
        {
            StatuePuzzle.puzzleComplete = true;
        }
        if (gameData.bookPuzzle == true)
        {
            BurningPuzzle.puzzleComplete = true;
        }
        Debug.Log(FibbonacciPuzzle.firstPuzzleAnswered);
        Debug.Log(FibbonacciPuzzle.secondPuzzleAnswered);
        Debug.Log(FibbonacciPuzzle.thirdPuzzleAnswered);
        Debug.Log(StatuePuzzle.puzzleComplete);
        Debug.Log(BurningPuzzle.puzzleComplete);
        if (gameObject.name == "PlayerCapsule")
        {
            cc.enabled = false;
            Vector3 pos = new Vector3(gameData.x, gameData.y, gameData.z);
            transform.position = pos;
            cc.enabled = true;
        }


        Debug.Log("Loaded");

        if (gameObject.name.Contains("Gorgon")) // || gameObject.name == "Gorgon(Clone)")
        {
            Vector3 gorgonPos = new Vector3(gameData.gorgonX, gameData.gorgonY, gameData.gorgonZ);
            transform.position = gorgonPos;
            Debug.Log("Gorgon loaded");
            Debug.Log(gameData.gorgonX);
        }

        if (gameObject.name.Contains("Knight"))
        {
            Vector3 knightPos = new Vector3(gameData.knightX, gameData.knightY, gameData.knightZ);
            transform.position = knightPos;
        }

        if (gameObject.name.Contains("Pirate"))
        {
            Vector3 piratePos = new Vector3(gameData.pirateX, gameData.pirateY, gameData.pirateZ);
            transform.position = piratePos;
        }

        if (gameObject.name.Contains("Wizard"))
        {
            Vector3 wizardPos = new Vector3(gameData.wizardX, gameData.wizardY, gameData.wizardZ);
            transform.position = wizardPos;
        }

        if (gameObject.name.Contains("Book1"))
        {
            Vector3 book1Pos = new Vector3(gameData.book1X, gameData.book1Y, gameData.book1Z);
            transform.position = book1Pos;
        }
        if (gameObject.name.Contains("Book2"))
        {
            Vector3 book2Pos = new Vector3(gameData.book2X, gameData.book2Y, gameData.book2Z);
            transform.position = book2Pos;
        }
        if (gameObject.name.Contains("Book3"))
        {
            Vector3 book3Pos = new Vector3(gameData.book3X, gameData.book3Y, gameData.book3Z);
            transform.position = book3Pos;
        }
        if (gameObject.name.Contains("Book4"))
        {
            Vector3 book4Pos = new Vector3(gameData.book4X, gameData.book4Y, gameData.book4Z);
            transform.position = book4Pos;
        }
        if (gameObject.name.Contains("Book5"))
        {
            Vector3 book5Pos = new Vector3(gameData.book5X, gameData.book5Y, gameData.book5Z);
            transform.position = book5Pos;
        }
        if (gameObject.name.Contains("Book6"))
        {
            Vector3 book6Pos = new Vector3(gameData.book6X, gameData.book6Y, gameData.book6Z);
            transform.position = book6Pos;
        }
    }
    public void SaveAndQuit()
    {
        SaveFile();
        PauseMenu.isSaving = true;
    }
    public void NewSave()
    {

    }
}


[System.Serializable]
public class GameData
{
    public string itemHolding;

    public float x;
    public float y;
    public float z;

    public float gorgonX;
    public float gorgonY;
    public float gorgonZ;

    public float knightX;
    public float knightY;
    public float knightZ;

    public float pirateX;
    public float pirateY;
    public float pirateZ;

    public float wizardX;
    public float wizardY;
    public float wizardZ;

    public float book1X;
    public float book1Y;
    public float book1Z;

    public float book2X;
    public float book2Y;
    public float book2Z;

    public float book3X;
    public float book3Y;
    public float book3Z;

    public float book4X;
    public float book4Y;
    public float book4Z;

    public float book5X;
    public float book5Y;
    public float book5Z;

    public float book6X;
    public float book6Y;
    public float book6Z;

    public bool statuePuzzle = false;
    public bool bookPuzzle = false;
    public bool fibonacciPuzzle = false;
    public bool colorPuzzle = false;

    public bool firstCode = false;
    public bool secondCode = false;
    public bool thirdCode = false;
    public bool fourthCode = false;
    public bool fifthCode = false; 
     
}
