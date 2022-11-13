using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SamBalance
{
    public class MovePlayer2D : MonoBehaviour
    {
        public float moveSpeed = 1;

        public Rigidbody2D rb;

        Vector2 movement;
      

        
        void Update()
        {

            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");

        }

        void FixedUpdate()
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }

        void OnCollisionEnter2D(Collision2D collisionInfo)
        {
            if (collisionInfo.collider.tag == "Enemy")
            {
                //Debug.Log("Colliding!");
                SceneManager.LoadScene("End");
            }
        }
    }
}