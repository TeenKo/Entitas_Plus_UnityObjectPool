using Entitas;
using UnityEngine;

namespace _Core_.Touch.Components
{
    [Input]
    public sealed class TouchDownPositionComponent : IComponent
    {
        /// <summary>
        /// Вектор начала касания
        /// </summary>
        public Vector2 value;
    }
}