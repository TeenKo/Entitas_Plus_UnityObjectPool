//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public _Core_.States.Components.StateObjectTypeComponent stateObjectType { get { return (_Core_.States.Components.StateObjectTypeComponent)GetComponent(GameComponentsLookup.StateObjectType); } }
    public bool hasStateObjectType { get { return HasComponent(GameComponentsLookup.StateObjectType); } }

    public void AddStateObjectType(_Core_.States.StateObjectType newValue) {
        var index = GameComponentsLookup.StateObjectType;
        var component = (_Core_.States.Components.StateObjectTypeComponent)CreateComponent(index, typeof(_Core_.States.Components.StateObjectTypeComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceStateObjectType(_Core_.States.StateObjectType newValue) {
        var index = GameComponentsLookup.StateObjectType;
        var component = (_Core_.States.Components.StateObjectTypeComponent)CreateComponent(index, typeof(_Core_.States.Components.StateObjectTypeComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveStateObjectType() {
        RemoveComponent(GameComponentsLookup.StateObjectType);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherStateObjectType;

    public static Entitas.IMatcher<GameEntity> StateObjectType {
        get {
            if (_matcherStateObjectType == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.StateObjectType);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherStateObjectType = matcher;
            }

            return _matcherStateObjectType;
        }
    }
}