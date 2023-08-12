using Entitas;

namespace _Core_.Car
{
    public sealed class CarSystems : Systems
    {
        public CarSystems(Contexts contexts)
        {
            Add(new NextPointReactiveSystem(contexts));
            Add(new NextPointDestinationReactiveSystem(contexts));
        }
    }
}