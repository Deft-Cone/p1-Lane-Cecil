using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallObjectCollide : MonoBehaviour
{ 
    public GameObject square;
    public GameObject diamond;
    public GameObject pill;
    public int score = 0;
    void OnCollisionEnter2D(Collision2D itemType)
    {
        if (itemType.gameObject.CompareTag("Square") ||
            itemType.gameObject.CompareTag("Diamond") ||
            itemType.gameObject.CompareTag("Pill"))
        {
            Debug.Log("hit a wall");
            itemType.gameObject.SetActive(false);
            score++;
        }
    }
}
