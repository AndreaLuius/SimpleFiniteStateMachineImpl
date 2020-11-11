using System;
using UnityEngine;

namespace Scenes
{
    public class Movement : MonoBehaviour
    {
        private float xAxis, zAxis;
        private Vector3 movement;
        private CharacterController characterController;
        private Animator animator;

        private void Start()
        {
            animator = GetComponent<Animator>();
            characterController = GetComponent<CharacterController>();
        }


        public void movementHandling()
        {
            xAxis = Input.GetAxis("Horizontal");
            zAxis = Input.GetAxis("Vertical");
            
            movement = Camera.main.transform.right * xAxis + Camera.main.transform.forward * zAxis;

            characterController.Move(movement * 2 * Time.deltaTime);
        }
       
    }
}