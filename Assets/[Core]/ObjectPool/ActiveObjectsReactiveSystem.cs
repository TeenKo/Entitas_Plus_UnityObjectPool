using System.Collections.Generic;
using Entitas;

namespace _Core_.ObjectPool
{
    public class ActiveObjectsReactiveSystem : ReactiveSystem<GameEntity>
    {
        private readonly Contexts _contexts;

        public ActiveObjectsReactiveSystem(Contexts contexts) : base(contexts.game)
        {
            _contexts = contexts;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.ActiveObjects.Added());
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.activeObjects.value > 0;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            var gameManagerEntity = _contexts.game.gameManagerEntity;
            
            foreach (var entity in entities)
            {
                if (entity.activeObjects.value < entity.totalPoolSize.value && gameManagerEntity.hasCarSpawnDelayTimer == false)
                {
                    _contexts.game.CreateEntity().isSpawnCar = true;
                }
            }
        }
    }
}