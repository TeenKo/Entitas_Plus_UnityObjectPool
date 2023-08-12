using System.Collections.Generic;
using Entitas;

namespace _Core_.States.Components
{
    [Game]
    public sealed class SearchAttackTargetStateComponent : IComponent, IGameContextState
    {
        public List<StateObjectType> SetSateObjectType()
        {
            var list = new List<StateObjectType>()
            {
                StateObjectType.Player,
                StateObjectType.Enemy,
                StateObjectType.SessionWeapon
            };

            return list;
        }
    }
}