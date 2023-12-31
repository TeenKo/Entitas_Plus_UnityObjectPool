//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly _Core_.States.Components.SearchAttackTargetStateComponent searchAttackTargetStateComponent = new _Core_.States.Components.SearchAttackTargetStateComponent();

    public bool isSearchAttackTargetState {
        get { return HasComponent(GameComponentsLookup.SearchAttackTargetState); }
        set {
            if (value != isSearchAttackTargetState) {
                var index = GameComponentsLookup.SearchAttackTargetState;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : searchAttackTargetStateComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<GameEntity> _matcherSearchAttackTargetState;

    public static Entitas.IMatcher<GameEntity> SearchAttackTargetState {
        get {
            if (_matcherSearchAttackTargetState == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SearchAttackTargetState);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSearchAttackTargetState = matcher;
            }

            return _matcherSearchAttackTargetState;
        }
    }
}
