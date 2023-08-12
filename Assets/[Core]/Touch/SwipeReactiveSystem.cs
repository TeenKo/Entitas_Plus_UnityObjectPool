using System.Collections.Generic;
using _Core_.Touch.Components;
using Entitas;
using UnityEngine;

namespace _Core_.Touch
{
    public class SwipeReactiveSystem :  ReactiveSystem<InputEntity>
    {
        private readonly Contexts _contexts;
        private InputEntity _inputDataEntity;
        private const float _minSwipeDist = 100f;
        
        public SwipeReactiveSystem(Contexts contexts) : base(contexts.input)
        {
            _contexts = contexts;
        }

        protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context)
        {
            return context.CreateCollector(InputMatcher.TouchPhase);
        }

        protected override bool Filter(InputEntity entity)
        {
            return _contexts.input.touchDataEntity.touchPhase.value == TouchPhase.Ended;
        }

        protected override void Execute(List<InputEntity> entities)
        {
            _inputDataEntity = _contexts.input.touchDataEntity;

            if (!SwipeDistanceCheckMet()) return;

            SwipeDirection direction;

            if (IsVerticalSwipe())
            {
                direction = _inputDataEntity.touchDownPosition.value.y - _inputDataEntity.touchUpPosition.value.y > 0
                    ? SwipeDirection.Up
                    : SwipeDirection.Down;
            }
            else
            {
                direction = _inputDataEntity.touchDownPosition.value.x - _inputDataEntity.touchUpPosition.value.x > 0
                    ? SwipeDirection.Right
                    : SwipeDirection.Left;
            }

            _inputDataEntity.ReplaceTouchSwipeDirection(direction);
        }

        private bool IsVerticalSwipe()
        {
            return VerticalMovementDistance() > HorizontalMovementDistance();
        }

        private bool SwipeDistanceCheckMet()
        {
            return VerticalMovementDistance() > _minSwipeDist || HorizontalMovementDistance() > _minSwipeDist;
        }

        private float VerticalMovementDistance()
        {
            return Mathf.Abs(_inputDataEntity.touchDownPosition.value.y - _inputDataEntity.touchUpPosition.value.y);
        }

        private float HorizontalMovementDistance()
        {
            return Mathf.Abs(_inputDataEntity.touchDownPosition.value.x - _inputDataEntity.touchUpPosition.value.x);
        }
    }
}