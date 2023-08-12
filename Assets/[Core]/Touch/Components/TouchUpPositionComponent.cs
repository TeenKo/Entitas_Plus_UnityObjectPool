using Entitas;
using UnityEngine;

namespace _Core_.Touch.Components
{
    [Input]
    public sealed class TouchUpPositionComponent : IComponent
    {
        /// <summary>
        /// Вектор конца касания
        /// </summary>
        public Vector2 value;
    }
}