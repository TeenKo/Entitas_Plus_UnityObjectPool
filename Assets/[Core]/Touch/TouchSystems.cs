using Entitas;

namespace _Core_.Touch
{
    public sealed class TouchSystems : Systems
    {
        public TouchSystems(Contexts contexts)
        {
            Add(new TouchExecuteSystem(contexts));
            Add(new SwipeReactiveSystem(contexts));
        }
    }
}