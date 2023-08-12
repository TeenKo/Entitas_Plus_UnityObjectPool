using Entitas;
using UnityEngine;

namespace _Core_.Common.Components
{
    [Game]
    public sealed class ModelComponent : IComponent
    {
        public Transform value;
    }
}