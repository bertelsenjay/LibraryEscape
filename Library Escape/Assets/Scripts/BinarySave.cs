using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class BinarySave : MonoBehaviour
{
    // game data to be saved
    GameData gameData;
    // name of file to write to
    string saveFile;
    CharacterController cc;

    FileStream dataStream;

    BinaryFormatter converter = new BinaryFormatter();

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            if(gameObject.name == "PlayerCapsule")
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

            if(gameObject.name.Contains("Pirate"))
            {
                gameData.pirateX = transform.position.x;
                gameData.pirateY = transform.position.y;
                gameData.pirateZ = transform.position.z; 
            }

            if(gameObject.name.Contains("Wizard"))
            {
                gameData.wizardX = transform.position.x;
                gameData.wizardY = transform.position.y;
                gameData.wizardZ = transform.position.z; 
            }
            WriteFile();
            Debug.Log("Saved");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {

            ReadFile();
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
}


[System.Serializable]
public class GameData
{
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
}
