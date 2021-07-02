using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pelicas
{
    public class SC_PlayerController : MonoBehaviour
    {
        [Header("Floats")]
        [SerializeField] private float movementSpeed;
        [SerializeField] private float damping = 5f;
        private float velocityY;
        private readonly float gravity = Physics.gravity.y;

        [Space]
        [Header("Bools")]
        public bool canMove;
        public bool wonMiniGame;
        public bool lostMiniGame;


        private Vector3 currentImpact;
       
        CharacterController characterController;
        Rigidbody rb;

        #region UNITY_FUNCTIONS
        #endregion


        #region PUBLIC_FUNCTIONS
        #endregion


        #region PRIVATE_FUNCTIONS
        #endregion

        private void Awake()
        {

            characterController = GetComponent<CharacterController>();
            rb = GetComponent<Rigidbody>();
        }

        private void Start()
        {
            canMove = true;
        }

        private void Update()
        {
            if (canMove)
            {
                Move();

                rb.useGravity = true;
            }
        
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


