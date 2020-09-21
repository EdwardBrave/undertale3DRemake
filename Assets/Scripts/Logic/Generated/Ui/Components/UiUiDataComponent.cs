//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class UiEntity {

    public Logic.Components.UI.UiDataComponent uiData { get { return (Logic.Components.UI.UiDataComponent)GetComponent(UiComponentsLookup.UiData); } }
    public bool hasUiData { get { return HasComponent(UiComponentsLookup.UiData); } }

    public void AddUiData(string newPath) {
        var index = UiComponentsLookup.UiData;
        var component = (Logic.Components.UI.UiDataComponent)CreateComponent(index, typeof(Logic.Components.UI.UiDataComponent));
        component.path = newPath;
        AddComponent(index, component);
    }

    public void ReplaceUiData(string newPath) {
        var index = UiComponentsLookup.UiData;
        var component = (Logic.Components.UI.UiDataComponent)CreateComponent(index, typeof(Logic.Components.UI.UiDataComponent));
        component.path = newPath;
        ReplaceComponent(index, component);
    }

    public void RemoveUiData() {
        RemoveComponent(UiComponentsLookup.UiData);
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

    static Entitas.IMatcher<UiEntity> _matcherUiData;

    public static Entitas.IMatcher<UiEntity> UiData {
        get {
            if (_matcherUiData == null) {
                var matcher = (Entitas.Matcher<UiEntity>)Entitas.Matcher<UiEntity>.AllOf(UiComponentsLookup.UiData);
                matcher.componentNames = UiComponentsLookup.componentNames;
                _matcherUiData = matcher;
            }

            return _matcherUiData;
        }
    }
}