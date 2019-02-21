using Player;
using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "playerObjectInstaller", menuName = "Installers/playerObjectInstaller")]
public class playerObjectInstaller : ScriptableObjectInstaller<playerObjectInstaller>
{
    public ScriptablePlayer player;
    public override void InstallBindings()
    {
         Container.BindInstance(player);
    }
}