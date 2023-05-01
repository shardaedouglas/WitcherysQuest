using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
        public GameObject mainPlayer;
        public int speed = 2; 
        public bool isOnGround = true;
        public float jumpSpeed = 8.0f;
        public float rotationSpeed = 0.5f;
        CharacterController myCharController;
        public float jumpForce = 3.0f;
        public const float gravity = 7.0f;
        public int _collectedScroll = 0;
        public Text scrollText;
        private Vector3 moving;



        void start() 
        {
                GetComponent<ParticleSystem>().Pause();
                myCharController = GetComponent<CharacterController>();
                moving = Vector3.zero;
        }

        void Update()
        {
                Rotation();
                Movement();

                moving.Normalize();
                UpdateScrollText();

                //Spell Casting Animation

                if(Input.GetMouseButton(0)) 
                {
                        GetComponent<ParticleSystem>().Play();
                        GetComponent<Animator>().Play("Witch_Attack");
                }
                if(Input.GetMouseButton(0))
                {
                        GetComponent<ParticleSystem>().Clear();
                }
        }
        //Player Movement Method
        void Movement()
        {
                moving = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
                moving *= speed;
                moving = transform.rotation * moving;
                moving.y -= gravity * Time.deltaTime;

                if(Input.GetButton("Jump"))
                {
                        moving.y = jumpForce;
                }

                if(Input.GetKey("down") || Input.GetKey("up") || Input.GetKey("left") || Input.GetKey("right"))
                {
                        GetComponent<Animator>().Play("Witch_Walk");
                }
                else
                {
                        GetComponent<Animator>().Play("Witch_Wait");
                }


                //Char controller movement

                myCharController.Move(moving * Time.deltaTime);
        }

        
        //Character Rotation
        void Rotation()
        {
                transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X") * 4.0f, 0));
        }

        //Scroll Mechanics
        void UpdateScrollText()
        {
                scrollText.text = "Scrolls: " + _collectedScroll;
        }


}
