using Zenject;
using Inputs;
using Player;
using UnityEngine;

namespace Scripts
{

    public class GameInstaller : MonoInstaller
    {
        public ViewPlayer player;
        public override void InstallBindings()
        {
            Container.Bind(typeof(IInputService), typeof(ITickable)).To<InputService>().AsSingle().NonLazy();
            //Container.Bind<IInputService>().To<InputService>().AsSingle().NonLazy();
            //Container.Bind<ITickable>().To<InputService>().AsSingle().NonLazy();
            Container.Bind<ITickable>().To<InputWASDService>().AsSingle().NonLazy();//Initializable,Dispozable;
            Container.Bind<IServicePlayer>().To<ServicePlayer>().AsSingle().NonLazy();
            Container.Bind<ModelPlayer>().To<ModelPlayer>().AsTransient();
            Container.Bind<ViewPlayer>().To<ViewPlayer>().FromInstance(player);
            Container.Bind<IControllerPlayer>().To<ControllerPlayer>().AsTransient(); //.AsTransient();

        }

    }
}