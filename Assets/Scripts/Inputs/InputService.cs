using System.Collections.Generic;
using Scripts;
using UnityEngine;

namespace Inputs
{
    public class InputService : Singleton<InputService>
    {
        public Dictionary<Controls, InputData> playerInput = new Dictionary<Controls, InputData>();
        public Dictionary<Controls, List<InputComponent>> inputComponents = new Dictionary<Controls, List<InputComponent>>();
        public void Update()
        {
            foreach (Controls controls in inputComponents.Keys)
            {
                foreach (InputComponent inputComponent in inputComponents[controls])
                {
                    //Debug.Log("Inputs send " + InputService.Instance.playerInput[controls].forward);
                    inputComponent.InputUpdate(InputService.Instance.playerInput[controls]);
                }
            }
        }
        public void AddPlayerInputData(Controls controls)
        {
            InputService.Instance.playerInput.Add(controls, new InputData());
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
                inputComponents[controls].Add(inputComponent);
            }
        }
    }
}