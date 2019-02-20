

using Inputs;
using UnityEngine;

namespace Player
{
    public class ControllerPlayer
    {
        ViewPlayer view;
        ModelPlayer model;
        InputComponent inputComponent;
        public ControllerPlayer(ViewPlayer player, Vector3 spawnPoint,ModelPlayer model)
        {
            inputComponent = new InputComponent(this);
            this.view = GameObject.Instantiate(player.gameObject, spawnPoint, Quaternion.identity, null).GetComponent<ViewPlayer>();
            view.SetController(this);
            this.model =model;
        }
        public void Move(float horizontal, float vertical)
        {
            if (horizontal != 0 || vertical != 0)
            {
                Debug.Log("moving");
                view.MovePlayer(horizontal * model.rotationSpeed * Time.deltaTime, vertical * model.speed * Time.deltaTime);
            }
        }
        public InputComponent GetInputComponent()
        {
            return inputComponent;
        }

    }

}