using System.Collections.Generic;

namespace _Core_.States
{
    public enum StateObjectType
    {
        Player,
        Enemy,
        PlayerPiece,
        GameManager,
        SessionWeapon
    }
    
    public interface IGameContextState
    {
        List<StateObjectType> SetSateObjectType();
    }
}
