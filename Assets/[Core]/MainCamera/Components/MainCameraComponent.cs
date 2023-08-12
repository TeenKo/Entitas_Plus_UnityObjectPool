using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace _Core_.MainCamera.Components
{
    [Game, Unique]
    public sealed class MainCameraComponent : IComponent
    {
        public Camera value;
    }
}
