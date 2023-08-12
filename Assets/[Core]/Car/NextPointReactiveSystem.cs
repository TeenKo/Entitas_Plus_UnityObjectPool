using System.Collections.Generic;
using Entitas;

namespace _Core_.Car
{
    public class NextPointReactiveSystem : ReactiveSystem<GameEntity>
    {
        private readonly Contexts _contexts;

        public NextPointReactiveSystem(Contexts contexts) : base(contexts.game)
        {
            _contexts = contexts;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.NextPoint.Added());
        }

        protected override bool Filter(GameEntity entity)
        {
            return true;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var entity in entities)
            {
                var position = entity.nextPoint.nextPoint;

                if (entity.nextPoint.isStart)
                {
                    entity.transform.value.position = position;
                    entity.isNextPointDestination = true;
                    continue;
                }

                entity.pathfinderAgent.value.MoveToDestination(position, () => entity.isNextPointDestination = true);
            }
        }
    }
}