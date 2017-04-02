//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public PositionComponent position { get { return (PositionComponent)GetComponent(TestComponentsLookup.Position); } }
    public bool hasPosition { get { return HasComponent(TestComponentsLookup.Position); } }

    public void AddPosition(int newX, int newY) {
        var index = TestComponentsLookup.Position;
        var component = CreateComponent<PositionComponent>(index);
        component.x = newX;
        component.y = newY;
        AddComponent(index, component);
    }

    public void ReplacePosition(int newX, int newY) {
        var index = TestComponentsLookup.Position;
        var component = CreateComponent<PositionComponent>(index);
        component.x = newX;
        component.y = newY;
        ReplaceComponent(index, component);
    }

    public void RemovePosition() {
        RemoveComponent(TestComponentsLookup.Position);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class TestMatcher {

    static Entitas.IMatcher<TestEntity> _matcherPosition;

    public static Entitas.IMatcher<TestEntity> Position {
        get {
            if(_matcherPosition == null) {
                var matcher = (Entitas.Matcher<TestEntity>)Entitas.Matcher<TestEntity>.AllOf(TestComponentsLookup.Position);
                matcher.componentNames = TestComponentsLookup.componentNames;
                _matcherPosition = matcher;
            }

            return _matcherPosition;
        }
    }
}