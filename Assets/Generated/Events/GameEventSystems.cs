//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class GameEventSystems : Feature {

    public GameEventSystems(Contexts contexts) {
        Add(new ChoosePlaceStateEventSystem(contexts)); // priority: 0
        Add(new DisableStateEventSystem(contexts)); // priority: 0
        Add(new EnableEventSystem(contexts)); // priority: 0
        Add(new IdleStateEventSystem(contexts)); // priority: 0
        Add(new IdleStateFeedBackEventSystem(contexts)); // priority: 0
        Add(new MoveStateEventSystem(contexts)); // priority: 0
        Add(new MoveStateRemovedEventSystem(contexts)); // priority: 0
    }
}
