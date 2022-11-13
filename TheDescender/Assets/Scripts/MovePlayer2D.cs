using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SamBalance
{
    public class MovePlayer2D : MonoBehaviour
    {
        //private Rigidbody2D rigidBody2D;
        //[SerializeField] float moveSpeed = 2f;
        /// Start is called before the first frame update
        public float moveSpeed = 1;

        public Rigidbody2D rb;

        Vector2 movement;

        // Update is called once per frame
        void Update()
        {
            //this extra code is just the way that I used to do it until i realized its not great code lol
            /*if (Input.GetKey(KeyCode.D)) //right
            {
                transform.position += Vector3.right * moveSpeed * Time.deltaTime;

            }

            else if (Input.GetKey(KeyCode.A)) //left
            {
                transform.position += Vector3.right * -moveSpeed * Time.deltaTime;

            }


            else if (Input.GetKey(KeyCode.W)) //up
            {
                transform.position += Vector3.up * moveSpeed * Time.deltaTime;

            }
            else if (Input.GetKey(KeyCode.S)) //down
            {
                transform.position += Vector3.up * -moveSpeed * Time.deltaTime;

            }
            */

            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");

        }

        void FixedUpdate()
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
    }
}