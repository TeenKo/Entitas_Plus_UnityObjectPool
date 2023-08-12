using Entitas;

namespace _Core_.Level
{
    public sealed class LevelSystems : Systems
    {
        public LevelSystems(Contexts contexts)
        {
            Add(new InitLevelSystem(contexts));
        }
    }
}