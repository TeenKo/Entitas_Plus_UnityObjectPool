//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public DisableStateListenerComponent disableStateListener { get { return (DisableStateListenerComponent)GetComponent(GameComponentsLookup.DisableStateListener); } }
    public bool hasDisableStateListener { get { return HasComponent(GameComponentsLookup.DisableStateListener); } }

    public void AddDisableStateListener(System.Collections.Generic.List<IDisableStateListener> newValue) {
        var index = GameComponentsLookup.DisableStateListener;
        var component = (DisableStateListenerComponent)CreateComponent(index, typeof(DisableStateListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceDisableStateListener(System.Collections.Generic.List<IDisableStateListener> newValue) {
        var index = GameComponentsLookup.DisableStateListener;
        var component = (DisableStateListenerComponent)CreateComponent(index, typeof(DisableStateListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveDisableStateListener() {
        RemoveComponent(GameComponentsLookup.DisableStateListener);
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

    static Entitas.IMatcher<GameEntity> _matcherDisableStateListener;

    public static Entitas.IMatcher<GameEntity> DisableStateListener {
        get {
            if (_matcherDisableStateListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.DisableStateListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherDisableStateListener = matcher;
            }

            return _matcherDisableStateListener;
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

    public void AddDisableStateListener(IDisableStateListener value) {
        var listeners = hasDisableStateListener
            ? disableStateListener.value
            : new System.Collections.Generic.List<IDisableStateListener>();
        listeners.Add(value);
        ReplaceDisableStateListener(listeners);
    }

    public void RemoveDisableStateListener(IDisableStateListener value, bool removeComponentWhenEmpty = true) {
        var listeners = disableStateListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveDisableStateListener();
        } else {
            ReplaceDisableStateListener(listeners);
        }
    }
}