
using System;
using Player;
using Scripts;
using UnityEngine;
using Zenject;

namespace Inputs
{
    public class InputWASDService : ITickable
    {
        IInputService inputService;
        Controls controls = Controls.WASD;
        InputData inputData;
        public InputWASDService(IInputService inputService)
        {
            this.inputService = inputService;
            inputService.AddPlayerInputData(controls);
        }

        // public event Action<ControllerPlayer, InputComponent, Controls> OnPlayerDeath;
        public void Tick()
        {
            inputData = new InputData();
            inputData.forward = Input.GetAxis("Horizontal");
            inputData.direction = Input.GetAxis("Vertical");
            inputService.SetInput(controls, inputData);
        }
    }
}