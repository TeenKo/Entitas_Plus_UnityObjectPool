using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace _Core_.Touch.Components
{
    [Input, Event(EventTarget.Self)]
    public sealed class TouchSwipeDirectionComponent : IComponent
    {
        /// <summary>
        /// Направления свайпа
        /// </summary>
        public SwipeDirection value;
    }
    
    public enum SwipeDirection
    {
        Up,
        Down,
        Left,
        Right
    }
}