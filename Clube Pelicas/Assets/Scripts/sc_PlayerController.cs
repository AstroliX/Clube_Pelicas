using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pelicas
{
    public class sc_PlayerController : MonoBehaviour
    {
        [SerializeField] private float movementSpeed;
        [SerializeField] private float damping = 5f;

        CharacterController characterController;
        private float velocityY;
        private Vector3 currentImpact;

        private readonly float gravity = Physics.gravity.y;

        private void Awake()
        {

            characterController = GetComponent<CharacterController>();
        }

        private void Update()
        {
            Move();
        }



        public void Move()
        {

            Vector3 movementInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical")).normalized;

            movementInput = transform.TransformDirection(movementInput);

           
            

            Vector3 velocity = movementInput * movementSpeed + Vector3.up * velocityY;
            if (currentImpact.magnitude > 0.2f)
            {
                velocity += currentImpact;
            }

            characterController.Move(velocity * Time.deltaTime);

            currentImpact = Vector3.Lerp(currentImpact, Vector3.zero, damping * Time.deltaTime);
        }
    }

}


