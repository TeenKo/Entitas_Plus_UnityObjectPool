using Entitas;
using UnityEngine;

namespace _Core_.Touch.Components
{
    [Input]
    public sealed class TouchPhaseComponent : IComponent
    {
        /// <summary>
        /// Фаза касания
        /// </summary>
        public TouchPhase value;
    }
}