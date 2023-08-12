//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public IdleStateFeedBackListenerComponent idleStateFeedBackListener { get { return (IdleStateFeedBackListenerComponent)GetComponent(GameComponentsLookup.IdleStateFeedBackListener); } }
    public bool hasIdleStateFeedBackListener { get { return HasComponent(GameComponentsLookup.IdleStateFeedBackListener); } }

    public void AddIdleStateFeedBackListener(System.Collections.Generic.List<IIdleStateFeedBackListener> newValue) {
        var index = GameComponentsLookup.IdleStateFeedBackListener;
        var component = (IdleStateFeedBackListenerComponent)CreateComponent(index, typeof(IdleStateFeedBackListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceIdleStateFeedBackListener(System.Collections.Generic.List<IIdleStateFeedBackListener> newValue) {
        var index = GameComponentsLookup.IdleStateFeedBackListener;
        var component = (IdleStateFeedBackListenerComponent)CreateComponent(index, typeof(IdleStateFeedBackListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveIdleStateFeedBackListener() {
        RemoveComponent(GameComponentsLookup.IdleStateFeedBackListener);
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

    static Entitas.IMatcher<GameEntity> _matcherIdleStateFeedBackListener;

    public static Entitas.IMatcher<GameEntity> IdleStateFeedBackListener {
        get {
            if (_matcherIdleStateFeedBackListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.IdleStateFeedBackListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherIdleStateFeedBackListener = matcher;
            }

            return _matcherIdleStateFeedBackListener;
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

    public void AddIdleStateFeedBackListener(IIdleStateFeedBackListener value) {
        var listeners = hasIdleStateFeedBackListener
            ? idleStateFeedBackListener.value
            : new System.Collections.Generic.List<IIdleStateFeedBackListener>();
        listeners.Add(value);
        ReplaceIdleStateFeedBackListener(listeners);
    }

    public void RemoveIdleStateFeedBackListener(IIdleStateFeedBackListener value, bool removeComponentWhenEmpty = true) {
        var listeners = idleStateFeedBackListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveIdleStateFeedBackListener();
        } else {
            ReplaceIdleStateFeedBackListener(listeners);
        }
    }
}
