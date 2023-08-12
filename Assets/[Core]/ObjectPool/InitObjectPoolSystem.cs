using _Core_.Spawner;
using Entitas;
using UnityEngine;

namespace _Core_.ObjectPool
{
    public class InitObjectPoolSystem : IInitializeSystem
    {
        private readonly Contexts _contexts;

        public InitObjectPoolSystem(Contexts contexts)
        {
            _contexts = contexts;
        }

        public void Initialize()
        {
            var carObjectPool = Object.FindObjectOfType<CarObjectPool>(includeInactive: true);
            var carObjectPoolEntity = _contexts.game.CreateEntity();
            carObjectPool.Link(carObjectPoolEntity);
        }
    }
}