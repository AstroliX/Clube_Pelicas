using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pelicas
{
    public class SC_CursorController : MonoBehaviour
    {
        [SerializeField] Texture2D cursorVEVO;
        [SerializeField] GameObject playerCamera;




        public void ActivateCursor()
        {
            //Cursor.SetCursor(cursorVEVO, Vector2.zero, CursorMode.Auto);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            //playerCamera.GetComponent<PlayerCamera>().enabled = false;



        }

        public void DeactivateCursor()
        {
            // playerCamera.GetComponent<PlayerCamera>().enabled = true;
            Cursor.visible = false;
        }
    }
}


