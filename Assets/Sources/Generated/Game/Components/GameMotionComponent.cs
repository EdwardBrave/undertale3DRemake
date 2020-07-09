//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Components.Game.MotionComponent motion { get { return (Components.Game.MotionComponent)GetComponent(GameComponentsLookup.Motion); } }
    public bool hasMotion { get { return HasComponent(GameComponentsLookup.Motion); } }

    public void AddMotion(float newMaxSpeed, float newSpeed) {
        var index = GameComponentsLookup.Motion;
        var component = (Components.Game.MotionComponent)CreateComponent(index, typeof(Components.Game.MotionComponent));
        component.maxSpeed = newMaxSpeed;
        component.speed = newSpeed;
        AddComponent(index, component);
    }

    public void ReplaceMotion(float newMaxSpeed, float newSpeed) {
        var index = GameComponentsLookup.Motion;
        var component = (Components.Game.MotionComponent)CreateComponent(index, typeof(Components.Game.MotionComponent));
        component.maxSpeed = newMaxSpeed;
        component.speed = newSpeed;
        ReplaceComponent(index, component);
    }

    public void RemoveMotion() {
        RemoveComponent(GameComponentsLookup.Motion);
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

    static Entitas.IMatcher<GameEntity> _matcherMotion;

    public static Entitas.IMatcher<GameEntity> Motion {
        get {
            if (_matcherMotion == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Motion);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMotion = matcher;
            }

            return _matcherMotion;
        }
    }
}