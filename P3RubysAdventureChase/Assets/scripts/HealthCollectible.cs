using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< Updated upstream
public class HealthCollectable : MonoBehaviour
=======
public class he : MonoBehaviour
>>>>>>> Stashed changes
{
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();
        if (controller != null)
        {
<<<<<<< Updated upstream
            if(controller.health < controller.maxHealth )
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);
            }
        }
                
=======

        }
                
        Debug.Log("Object that entered the trigger is: " + other);
>>>>>>> Stashed changes
    }
}
