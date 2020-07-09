//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Components.Game.MoveInDirectionComponent moveInDirection { get { return (Components.Game.MoveInDirectionComponent)GetComponent(GameComponentsLookup.MoveInDirection); } }
    public bool hasMoveInDirection { get { return HasComponent(GameComponentsLookup.MoveInDirection); } }

    public void AddMoveInDirection(UnityEngine.Vector3 newVector) {
        var index = GameComponentsLookup.MoveInDirection;
        var component = (Components.Game.MoveInDirectionComponent)CreateComponent(index, typeof(Components.Game.MoveInDirectionComponent));
        component.vector = newVector;
        AddComponent(index, component);
    }

    public void ReplaceMoveInDirection(UnityEngine.Vector3 newVector) {
        var index = GameComponentsLookup.MoveInDirection;
        var component = (Components.Game.MoveInDirectionComponent)CreateComponent(index, typeof(Components.Game.MoveInDirectionComponent));
        component.vector = newVector;
        ReplaceComponent(index, component);
    }

    public void RemoveMoveInDirection() {
        RemoveComponent(GameComponentsLookup.MoveInDirection);
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

    static Entitas.IMatcher<GameEntity> _matcherMoveInDirection;

    public static Entitas.IMatcher<GameEntity> MoveInDirection {
        get {
            if (_matcherMoveInDirection == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.MoveInDirection);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMoveInDirection = matcher;
            }

            return _matcherMoveInDirection;
        }
    }
}