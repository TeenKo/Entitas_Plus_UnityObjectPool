using Entitas;
using UnityEngine;

namespace _Core_.Level
{
    public class InitLevelSystem : IInitializeSystem
    {
        private readonly Contexts _contexts;

        public InitLevelSystem(Contexts contexts)
        {
            _contexts = contexts;
        }

        public void Initialize()
        {
            var levelView = Object.FindObjectOfType<LevelView>(includeInactive: true);
            var levelEntity = _contexts.game.CreateEntity();
            levelView.Link(levelEntity);
        }
    }
}