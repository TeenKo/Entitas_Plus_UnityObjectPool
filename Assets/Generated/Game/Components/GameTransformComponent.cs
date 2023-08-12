//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public _Core_.Common.Components.TransformComponent transform { get { return (_Core_.Common.Components.TransformComponent)GetComponent(GameComponentsLookup.Transform); } }
    public bool hasTransform { get { return HasComponent(GameComponentsLookup.Transform); } }

    public void AddTransform(UnityEngine.Transform newValue) {
        var index = GameComponentsLookup.Transform;
        var component = (_Core_.Common.Components.TransformComponent)CreateComponent(index, typeof(_Core_.Common.Components.TransformComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTransform(UnityEngine.Transform newValue) {
        var index = GameComponentsLookup.Transform;
        var component = (_Core_.Common.Components.TransformComponent)CreateComponent(index, typeof(_Core_.Common.Components.TransformComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveTransform() {
        RemoveComponent(GameComponentsLookup.Transform);
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

    static Entitas.IMatcher<GameEntity> _matcherTransform;

    public static Entitas.IMatcher<GameEntity> Transform {
        get {
            if (_matcherTransform == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Transform);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherTransform = matcher;
            }

            return _matcherTransform;
        }
    }
}
