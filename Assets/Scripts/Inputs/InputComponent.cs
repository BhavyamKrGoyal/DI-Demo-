using Player;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inputs
{
    public class InputComponent
    {
        ControllerPlayer controller;

        public InputComponent(ControllerPlayer controller)
        {
            this.controller = controller;
            //InputManager.Instance.RegisterInputComponent(this,controller.GetControls());
        }
        public void InputUpdate(InputData inputData)
        {
            controller.Move(inputData.forward, inputData.direction);
        }

    }
}