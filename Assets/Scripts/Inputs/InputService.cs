using System.Collections.Generic;
using Scripts;
using UnityEngine;
using Zenject;

namespace Inputs
{
    public class InputService : IInputService, ITickable
    {
        public Dictionary<Controls, InputData> playerInput = new Dictionary<Controls, InputData>();
        public Dictionary<Controls, List<InputComponent>> inputComponents = new Dictionary<Controls, List<InputComponent>>();

        public InputService()
        {
            Debug.Log("InputSetrvice constructer");
        }
        public void Tick()
        {

            foreach (Controls controls in inputComponents.Keys)
            {
                foreach (InputComponent inputComponent in inputComponents[controls])
                {          
                    inputComponent.InputUpdate(playerInput[controls]);
                }
            }
        }
        public void SetInput(Controls controls, InputData data)
        {
            playerInput[controls] = data;
        }
        public void AddPlayerInputData(Controls controls)
        {

            playerInput.Add(controls, new InputData());
        }
        public void RegisterInputComponent(InputComponent inputComponent, Controls controls)
        {
            if (!inputComponents.ContainsKey(controls))
            {
                
                List<InputComponent> newList = new List<InputComponent>();
                newList.Add(inputComponent);
                inputComponents.Add(controls, newList);
            }
            else
            {
                Debug.Log("setting inputcomponent");
                inputComponents[controls].Add(inputComponent);
            }
        }
    }
}