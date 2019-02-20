
using System.Collections.Generic;
using Inputs;
using Scripts;
using UnityEngine;

namespace Player
{
    public class ServicePlayer : Singleton<ServicePlayer>
    {
        public ViewPlayer player;
         public List<ControllerPlayer> players = new List<ControllerPlayer>();
        private void Start()
        {
            ControllerPlayer controllerPlayer=new ControllerPlayer(player,new Vector3(0,5,0),new ModelPlayer());
            players.Add(controllerPlayer);
            InputService.Instance.RegisterInputComponent(controllerPlayer.GetInputComponent(),Controls.WASD);
        }
    }
}