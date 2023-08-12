﻿using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace _Core_.GameManager
{
    public class CarSpawnDelayTimerReactiveSystem : ReactiveSystem<GameEntity>
    {
        private readonly Contexts _contexts;

        public CarSpawnDelayTimerReactiveSystem(Contexts contexts) : base(contexts.game)
        {
            _contexts = contexts;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.CarSpawnDelayTimer.Added());
        }

        protected override bool Filter(GameEntity entity)
        {
            return true;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var entity in entities)
            {
                var time = entity.carSpawnDelayTimer.value - Time.deltaTime;

                if (time <= 0)
                {
                    _contexts.game.CreateEntity().isSpawnCar = true;
                    entity.RemoveCarSpawnDelayTimer();
                    continue;
                }
                
                entity.ReplaceCarSpawnDelayTimer(time);
            }
        }
    }
}