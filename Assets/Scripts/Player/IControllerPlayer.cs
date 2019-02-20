using Inputs;
namespace Player
{
    public interface IControllerPlayer
    {
        void Move(float horizontal, float vertical);
        InputComponent GetInputComponent();
    }
}