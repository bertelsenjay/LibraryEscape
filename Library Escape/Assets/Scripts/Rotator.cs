using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] Vector3 rotation;
    public static bool placeGorgon = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if (placeGorgon == true && gameObject.name == "Gorgon")
        {
            transform.Rotate(rotation);
            placeGorgon = false;
        }
        
    }
}
