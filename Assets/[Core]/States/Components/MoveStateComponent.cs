using System.Collections.Generic;
using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace _Core_.States.Components
{
    [Game, Event(EventTarget.Self), Event(EventTarget.Self, EventType.Removed)]
    public sealed class MoveStateComponent : IComponent, IGameContextState
    {
        public List<StateObjectType> SetSateObjectType()
        {
            var list = new List<StateObjectType>()
            {
                StateObjectType.Enemy,
                StateObjectType.SessionWeapon
            };

            return list;
        }
    }
}