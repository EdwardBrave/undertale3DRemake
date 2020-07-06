//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class UiEntity {

    public Components.UI.CanvasComponent canvas { get { return (Components.UI.CanvasComponent)GetComponent(UiComponentsLookup.Canvas); } }
    public bool hasCanvas { get { return HasComponent(UiComponentsLookup.Canvas); } }

    public void AddCanvas(string newName, System.Collections.Generic.List<UiEntity> newWindows) {
        var index = UiComponentsLookup.Canvas;
        var component = (Components.UI.CanvasComponent)CreateComponent(index, typeof(Components.UI.CanvasComponent));
        component.name = newName;
        component.windows = newWindows;
        AddComponent(index, component);
    }

    public void ReplaceCanvas(string newName, System.Collections.Generic.List<UiEntity> newWindows) {
        var index = UiComponentsLookup.Canvas;
        var component = (Components.UI.CanvasComponent)CreateComponent(index, typeof(Components.UI.CanvasComponent));
        component.name = newName;
        component.windows = newWindows;
        ReplaceComponent(index, component);
    }

    public void RemoveCanvas() {
        RemoveComponent(UiComponentsLookup.Canvas);
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

    static Entitas.IMatcher<UiEntity> _matcherCanvas;

    public static Entitas.IMatcher<UiEntity> Canvas {
        get {
            if (_matcherCanvas == null) {
                var matcher = (Entitas.Matcher<UiEntity>)Entitas.Matcher<UiEntity>.AllOf(UiComponentsLookup.Canvas);
                matcher.componentNames = UiComponentsLookup.componentNames;
                _matcherCanvas = matcher;
            }

            return _matcherCanvas;
        }
    }
}
