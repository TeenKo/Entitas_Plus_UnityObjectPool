using Entitas;
using UnityEngine;

namespace _Core_.Touch.Components
{
    [Input]
    public sealed class TouchDeltaComponent : IComponent
    {
        public Vector2 value;
    }
}