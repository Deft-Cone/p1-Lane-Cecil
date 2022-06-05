using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Collect : MonoBehaviour
{
    public GameObject square;
    public GameObject diamond;
    public GameObject pill;
    
    void OnCollisionEnter2D(Collision2D itemType)
    {
        Debug.Log("uh");
        if (itemType.collider.tag == "Square")
        {
            Debug.Log("collected!");
            square.SetActive(false);
        }
        else if (itemType.gameObject.tag == "Diamond")
        {
            Debug.Log("collected!");
            diamond.SetActive(false);
        }
        else {
            Debug.Log("collected!");
            pill.SetActive(false);
        }
    }
    
}
