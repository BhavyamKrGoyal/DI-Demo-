using UnityEngine;
namespace Player
{
    [CreateAssetMenu(fileName = "scriptablePlayer", menuName = "ScriptableObject/scriptablePlayer")]
    public class ScriptablePlayer:ScriptableObject
    {
        public ViewPlayer playerView;
    }
}