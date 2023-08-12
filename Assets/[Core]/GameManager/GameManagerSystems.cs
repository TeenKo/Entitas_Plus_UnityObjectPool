using Entitas;

namespace _Core_.GameManager
{
    public sealed class GameManagerSystems : Systems
    {
        public GameManagerSystems(Contexts contexts)
        {
            Add(new InitGameManagerSystem(contexts));
            Add(new SpawnCarReactiveSystem(contexts));
            Add(new CarSpawnDelayTimerReactiveSystem(contexts));
        }
    }
}