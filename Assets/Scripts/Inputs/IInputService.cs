using Scripts;
namespace Inputs
{
    public interface IInputService
    {
         void AddPlayerInputData(Controls controls);
         void RegisterInputComponent(InputComponent inputComponent, Controls controls);
         void SetInput(Controls controls,InputData data);
    }
}