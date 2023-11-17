using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class he : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();
        if (controller != null)
        {

        }
                
        Debug.Log("Object that entered the trigger is: " + other);
    }
}
