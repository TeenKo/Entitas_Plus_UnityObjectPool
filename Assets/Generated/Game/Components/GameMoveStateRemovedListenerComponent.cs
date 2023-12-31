//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public MoveStateRemovedListenerComponent moveStateRemovedListener { get { return (MoveStateRemovedListenerComponent)GetComponent(GameComponentsLookup.MoveStateRemovedListener); } }
    public bool hasMoveStateRemovedListener { get { return HasComponent(GameComponentsLookup.MoveStateRemovedListener); } }

    public void AddMoveStateRemovedListener(System.Collections.Generic.List<IMoveStateRemovedListener> newValue) {
        var index = GameComponentsLookup.MoveStateRemovedListener;
        var component = (MoveStateRemovedListenerComponent)CreateComponent(index, typeof(MoveStateRemovedListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceMoveStateRemovedListener(System.Collections.Generic.List<IMoveStateRemovedListener> newValue) {
        var index = GameComponentsLookup.MoveStateRemovedListener;
        var component = (MoveStateRemovedListenerComponent)CreateComponent(index, typeof(MoveStateRemovedListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveMoveStateRemovedListener() {
        RemoveComponent(GameComponentsLookup.MoveStateRemovedListener);
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

    static Entitas.IMatcher<GameEntity> _matcherMoveStateRemovedListener;

    public static Entitas.IMatcher<GameEntity> MoveStateRemovedListener {
        get {
            if (_matcherMoveStateRemovedListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.MoveStateRemovedListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMoveStateRemovedListener = matcher;
            }

            return _matcherMoveStateRemovedListener;
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

    public void AddMoveStateRemovedListener(IMoveStateRemovedListener value) {
        var listeners = hasMoveStateRemovedListener
            ? moveStateRemovedListener.value
            : new System.Collections.Generic.List<IMoveStateRemovedListener>();
        listeners.Add(value);
        ReplaceMoveStateRemovedListener(listeners);
    }

    public void RemoveMoveStateRemovedListener(IMoveStateRemovedListener value, bool removeComponentWhenEmpty = true) {
        var listeners = moveStateRemovedListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveMoveStateRemovedListener();
        } else {
            ReplaceMoveStateRemovedListener(listeners);
        }
    }
}
