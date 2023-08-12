//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly _Core_.States.Components.ChoosePlaceStateComponent choosePlaceStateComponent = new _Core_.States.Components.ChoosePlaceStateComponent();

    public bool isChoosePlaceState {
        get { return HasComponent(GameComponentsLookup.ChoosePlaceState); }
        set {
            if (value != isChoosePlaceState) {
                var index = GameComponentsLookup.ChoosePlaceState;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : choosePlaceStateComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherChoosePlaceState;

    public static Entitas.IMatcher<GameEntity> ChoosePlaceState {
        get {
            if (_matcherChoosePlaceState == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ChoosePlaceState);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherChoosePlaceState = matcher;
            }

            return _matcherChoosePlaceState;
        }
    }
}
