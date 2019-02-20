

using Inputs;
using UnityEngine;

namespace Player
{
    public class ControllerPlayer : IControllerPlayer
    {
        ViewPlayer view;
        ModelPlayer model;
        InputComponent inputComponent;
        public ControllerPlayer(ViewPlayer player,ModelPlayer model)
        {
            this.model = model;
            Debug.Log("Player Constructor");
            inputComponent = new InputComponent(this);
            this.view = GameObject.Instantiate(player.gameObject, model.position, Quaternion.identity, null).GetComponent<ViewPlayer>();
            view.SetController(this);
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