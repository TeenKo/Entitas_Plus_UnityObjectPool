//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public EnableListenerComponent enableListener { get { return (EnableListenerComponent)GetComponent(GameComponentsLookup.EnableListener); } }
    public bool hasEnableListener { get { return HasComponent(GameComponentsLookup.EnableListener); } }

    public void AddEnableListener(System.Collections.Generic.List<IEnableListener> newValue) {
        var index = GameComponentsLookup.EnableListener;
        var component = (EnableListenerComponent)CreateComponent(index, typeof(EnableListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceEnableListener(System.Collections.Generic.List<IEnableListener> newValue) {
        var index = GameComponentsLookup.EnableListener;
        var component = (EnableListenerComponent)CreateComponent(index, typeof(EnableListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveEnableListener() {
        RemoveComponent(GameComponentsLookup.EnableListener);
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

    static Entitas.IMatcher<GameEntity> _matcherEnableListener;

    public static Entitas.IMatcher<GameEntity> EnableListener {
        get {
            if (_matcherEnableListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EnableListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEnableListener = matcher;
            }

            return _matcherEnableListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public void AddEnableListener(IEnableListener value) {
        var listeners = hasEnableListener
            ? enableListener.value
            : new System.Collections.Generic.List<IEnableListener>();
        listeners.Add(value);
        ReplaceEnableListener(listeners);
    }

    public void RemoveEnableListener(IEnableListener value, bool removeComponentWhenEmpty = true) {
        var listeners = enableListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveEnableListener();
        } else {
            ReplaceEnableListener(listeners);
        }
    }
}