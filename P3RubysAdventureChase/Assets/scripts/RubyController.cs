using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    public float speed = 3.0f;
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
    public int maxHealth = 5;
    public float timeInvincible = 2;
    public int health { get { return currentHealth; } }
    int currentHealth;

    bool isInvincible;
    float invincibleTimer;

    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
<<<<<<< Updated upstream
     
=======
>>>>>>> Stashed changes
    }
        // Update is called once per frame
        void Update()
        {
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");

            if (isInvincible);
            {
                invincibleTimer -= Timer.deltaTime;
            }


        }
        void FixedUpdate()
        {
            Vector2 position = transform.position;
            position.x = position.x + speed * horizontal;
            position.y = position.y + speed * vertical;

            rigidbody2d.MovePosition(position);
        }


<<<<<<< Updated upstream
        public void ChangeHealth(int amount)
=======
        void ChangeHealth(int amount)
>>>>>>> Stashed changes
        {
            currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
            Debug.Log(currentHealth + "/" + maxHealth);
        }
    }