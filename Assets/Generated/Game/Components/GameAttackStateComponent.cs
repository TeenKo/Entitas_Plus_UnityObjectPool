//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly _Core_.States.Components.AttackStateComponent attackStateComponent = new _Core_.States.Components.AttackStateComponent();

    public bool isAttackState {
        get { return HasComponent(GameComponentsLookup.AttackState); }
        set {
            if (value != isAttackState) {
                var index = GameComponentsLookup.AttackState;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : attackStateComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherAttackState;

    public static Entitas.IMatcher<GameEntity> AttackState {
        get {
            if (_matcherAttackState == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.AttackState);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherAttackState = matcher;
            }

            return _matcherAttackState;
        }
    }
}
