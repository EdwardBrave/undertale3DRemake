//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class UiEntity {

    static readonly Components.UI.ProtectedComponent protectedComponent = new Components.UI.ProtectedComponent();

    public bool isProtected {
        get { return HasComponent(UiComponentsLookup.Protected); }
        set {
            if (value != isProtected) {
                var index = UiComponentsLookup.Protected;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : protectedComponent;

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
public sealed partial class UiMatcher {

    static Entitas.IMatcher<UiEntity> _matcherProtected;

    public static Entitas.IMatcher<UiEntity> Protected {
        get {
            if (_matcherProtected == null) {
                var matcher = (Entitas.Matcher<UiEntity>)Entitas.Matcher<UiEntity>.AllOf(UiComponentsLookup.Protected);
                matcher.componentNames = UiComponentsLookup.componentNames;
                _matcherProtected = matcher;
            }

            return _matcherProtected;
        }
    }
}
