using System.Collections.Generic;
using System.Linq;
using _Core_.Common;
using Entitas;
using UnityEngine;

namespace _Core_.Car
{
    public class NextPointDestinationReactiveSystem : ReactiveSystem<GameEntity>
    {
        private readonly Contexts _contexts;
        private readonly IGroup<GameEntity> _navigationAreaEntitiesGroup;

        public NextPointDestinationReactiveSystem(Contexts contexts) : base(contexts.game)
        {
            _contexts = contexts;
            _navigationAreaEntitiesGroup = contexts.game.GetGroup(GameMatcher.NavigationArea);
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.NextPointDestination.Added());
        }

        protected override bool Filter(GameEntity entity)
        {
            return true;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var entity in entities)
            {
                entity.isNextPointDestination = false;
                
                if (entity.nextPoint.isFinish)
                {
                    entity.Destroy();
                    var carPoolEntity = _contexts.game.carPoolObjectEntity;
                    carPoolEntity.carPoolObject.value.RecalculateObjectsInPool();
                }
                else
                {
                    var index = entity.nextPoint.index + 1;
                    
                    var navigationAreaEntity = _navigationAreaEntitiesGroup.GetEntities()
                        .FirstOrDefault(e => e.index.value == index);
                    
                    if (navigationAreaEntity == null)
                    {
                        Debug.Log("navigationAreaEntity == null");
                        return;
                    }

                    var position = GameTools.RandomPointInBounds(navigationAreaEntity.bounds.value);
                    position.y = navigationAreaEntity.transform.value.position.y;
                    
                    entity.ReplaceNextPoint(
                        position,
                        navigationAreaEntity.index.value,
                        navigationAreaEntity.isFinish,
                        navigationAreaEntity.isStart);
                }
            }
        }
    }
}