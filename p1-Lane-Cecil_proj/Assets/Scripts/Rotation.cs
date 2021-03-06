using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotation : MonoBehaviour
{
    public float rotateDirection;
    public float rotationSpeed;
    public bool clockwiseRotation;
    public Menu effectsOn; 

    // Update is called once per frame
    void Update()
    {
        // if (effectsOn.VFX)
        // {
            if (clockwiseRotation == false)
            {
                rotateDirection += Time.deltaTime * rotationSpeed;
            }
            else
            {
                rotateDirection += -Time.deltaTime * rotationSpeed;
            }

            transform.rotation = Quaternion.Euler(0, 0, rotateDirection);
        // }
    }
}
