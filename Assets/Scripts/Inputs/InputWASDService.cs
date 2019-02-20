
using System;
using Player;
using Scripts;
using UnityEngine;

namespace Inputs
{
    public class InputWASDService : MonoBehaviour
    {
        InputData inputData;
        Controls controls = Controls.WASD;
        // public event Action<ControllerPlayer, InputComponent, Controls> OnPlayerDeath;
        private void Start()
        {
            InputService.Instance.AddPlayerInputData(controls);

        }
        public void Update()
        {
            inputData = new InputData();
            inputData.forward = Input.GetAxis("Horizontal");
            inputData.direction = Input.GetAxis("Vertical");
            //Debug.Log("getting Input using IJKL");
            InputService.Instance.playerInput[controls]=inputData;
        } 
    }
}