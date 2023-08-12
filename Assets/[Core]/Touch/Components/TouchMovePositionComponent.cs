using Entitas;
using UnityEngine;

namespace _Core_.Touch.Components
{
    [Input]
    public sealed class TouchMovePositionComponent : IComponent
    {
        /// <summary>
        /// Вектор движения тача
        /// </summary>
        public Vector2 value;
    }
}