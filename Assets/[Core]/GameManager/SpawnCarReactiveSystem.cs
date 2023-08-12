using System.Collections.Generic;
using _Core_.Common;
using Entitas;

namespace _Core_.GameManager
{
    public class SpawnCarReactiveSystem : ReactiveSystem<GameEntity>
    {
        private readonly Contexts _contexts;
        private readonly IGroup<GameEntity> _navigationAreaEntitiesGroup;

        public SpawnCarReactiveSystem(Contexts contexts) : base(contexts.game)
        {
            _contexts = contexts;
            _navigationAreaEntitiesGroup =
                contexts.game.GetGroup(GameMatcher.AllOf(GameMatcher.NavigationArea, GameMatcher.Start));
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.SpawnCar.Added());
        }

        protected override bool Filter(GameEntity entity)
        {
            return true;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var entity in entities)
            {
                var carPoolEntity = _contexts.game.carPoolObjectEntity;
                carPoolEntity.carPoolObject.value.RecalculateObjectsInPool();
                if(carPoolEntity.activeObjects.value >= carPoolEntity.totalPoolSize.value) continue;
                
                var carEntity = _contexts.game.CreateEntity();
                var carView = carPoolEntity.carPoolObject.value.GetCarFromPool();
                carView.Link(carEntity);

                foreach (var navigationAreaEntity in _navigationAreaEntitiesGroup.GetEntities())
                {
                    var position = GameTools.RandomPointInBounds(navigationAreaEntity.bounds.value);
                    position.y = navigationAreaEntity.transform.value.position.y;
                    carEntity.AddNextPoint(
                        position,
                        navigationAreaEntity.index.value,
                        navigationAreaEntity.isFinish,
                        navigationAreaEntity.isStart);

                    var gameManagerEntity = _contexts.game.gameManagerEntity;
                    gameManagerEntity.AddCarSpawnDelayTimer(2f);
                }
            }
        }
    }
}