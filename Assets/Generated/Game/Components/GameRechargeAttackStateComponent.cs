//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly _Core_.States.Components.RechargeAttackStateComponent rechargeAttackStateComponent = new _Core_.States.Components.RechargeAttackStateComponent();

    public bool isRechargeAttackState {
        get { return HasComponent(GameComponentsLookup.RechargeAttackState); }
        set {
            if (value != isRechargeAttackState) {
                var index = GameComponentsLookup.RechargeAttackState;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : rechargeAttackStateComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherRechargeAttackState;

    public static Entitas.IMatcher<GameEntity> RechargeAttackState {
        get {
            if (_matcherRechargeAttackState == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.RechargeAttackState);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherRechargeAttackState = matcher;
            }

            return _matcherRechargeAttackState;
        }
    }
}
