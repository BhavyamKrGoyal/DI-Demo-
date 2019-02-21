
using System.Collections.Generic;
using Inputs;
using Scripts;
using UnityEngine;
using Zenject;

namespace Player
{
    public class ServicePlayer : IServicePlayer
    {
        IInputService inputService;
        public List<IControllerPlayer> players = new List<IControllerPlayer>();
        public ServicePlayer(IInputService inputService, ScriptablePlayer player)
        {
            players = new List<IControllerPlayer>();
            ControllerPlayer controllerPlayer=new ControllerPlayer(player.playerView);
            this.inputService = inputService;
            Debug.Log("playerService Constructer");
            inputService.RegisterInputComponent(controllerPlayer.GetInputComponent(), Controls.WASD);
            players.Add(controllerPlayer);
        }
    }
}