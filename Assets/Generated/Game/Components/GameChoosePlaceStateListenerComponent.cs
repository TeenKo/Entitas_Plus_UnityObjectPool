//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public ChoosePlaceStateListenerComponent choosePlaceStateListener { get { return (ChoosePlaceStateListenerComponent)GetComponent(GameComponentsLookup.ChoosePlaceStateListener); } }
    public bool hasChoosePlaceStateListener { get { return HasComponent(GameComponentsLookup.ChoosePlaceStateListener); } }

    public void AddChoosePlaceStateListener(System.Collections.Generic.List<IChoosePlaceStateListener> newValue) {
        var index = GameComponentsLookup.ChoosePlaceStateListener;
        var component = (ChoosePlaceStateListenerComponent)CreateComponent(index, typeof(ChoosePlaceStateListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceChoosePlaceStateListener(System.Collections.Generic.List<IChoosePlaceStateListener> newValue) {
        var index = GameComponentsLookup.ChoosePlaceStateListener;
        var component = (ChoosePlaceStateListenerComponent)CreateComponent(index, typeof(ChoosePlaceStateListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveChoosePlaceStateListener() {
        RemoveComponent(GameComponentsLookup.ChoosePlaceStateListener);
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

    static Entitas.IMatcher<GameEntity> _matcherChoosePlaceStateListener;

    public static Entitas.IMatcher<GameEntity> ChoosePlaceStateListener {
        get {
            if (_matcherChoosePlaceStateListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ChoosePlaceStateListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherChoosePlaceStateListener = matcher;
            }

            return _matcherChoosePlaceStateListener;
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

    public void AddChoosePlaceStateListener(IChoosePlaceStateListener value) {
        var listeners = hasChoosePlaceStateListener
            ? choosePlaceStateListener.value
            : new System.Collections.Generic.List<IChoosePlaceStateListener>();
        listeners.Add(value);
        ReplaceChoosePlaceStateListener(listeners);
    }

    public void RemoveChoosePlaceStateListener(IChoosePlaceStateListener value, bool removeComponentWhenEmpty = true) {
        var listeners = choosePlaceStateListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveChoosePlaceStateListener();
        } else {
            ReplaceChoosePlaceStateListener(listeners);
        }
    }
}
