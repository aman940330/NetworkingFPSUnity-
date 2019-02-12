﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.Networking;

namespace S1
{
    public class PlayerToggleCursor : NetworkBehaviour
    {

        public FirstPersonController fpsController;


        // Update is called once per frame
        void Update()
        {
            if (!isLocalPlayer)
            {
                return;
            }

            if (Input.GetButtonUp("Cancel"))
            {
                ToggleCursor();
            }

        }

        void ToggleCursor()
        {
            fpsController.enabled = !fpsController.enabled;
        }
    }
}


