//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly _Core_.ObjectPool.Components.PoolObjectComponent poolObjectComponent = new _Core_.ObjectPool.Components.PoolObjectComponent();

    public bool isPoolObject {
        get { return HasComponent(GameComponentsLookup.PoolObject); }
        set {
            if (value != isPoolObject) {
                var index = GameComponentsLookup.PoolObject;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : poolObjectComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherPoolObject;

    public static Entitas.IMatcher<GameEntity> PoolObject {
        get {
            if (_matcherPoolObject == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PoolObject);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPoolObject = matcher;
            }

            return _matcherPoolObject;
        }
    }
}