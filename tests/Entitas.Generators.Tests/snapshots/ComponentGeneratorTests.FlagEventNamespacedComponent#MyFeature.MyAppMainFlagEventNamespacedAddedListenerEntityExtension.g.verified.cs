﻿//HintName: MyFeature.MyAppMainFlagEventNamespacedAddedListenerEntityExtension.g.cs
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by
//     Entitas.Generators.ComponentGenerator.EntityExtension
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using global::MyApp.Main;
using static global::MyFeature.MyAppMainFlagEventNamespacedAddedListenerComponentIndex;

namespace MyFeature
{
public static class MyAppMainFlagEventNamespacedAddedListenerEntityExtension
{
    public static bool HasFlagEventNamespacedAddedListener(this Entity entity)
    {
        return entity.HasComponent(Index.Value);
    }

    public static Entity AddFlagEventNamespacedAddedListener(this Entity entity, global::System.Collections.Generic.List<IMyAppMainFlagEventNamespacedAddedListener> value)
    {
        var index = Index.Value;
        var componentPool = entity.GetComponentPool(index);
        var component = componentPool.Count > 0
            ? (MyAppMainFlagEventNamespacedAddedListenerComponent)componentPool.Pop()
            : new MyAppMainFlagEventNamespacedAddedListenerComponent();
        component.Value = value;
        entity.AddComponent(index, component);
        return entity;
    }

    public static Entity ReplaceFlagEventNamespacedAddedListener(this Entity entity, global::System.Collections.Generic.List<IMyAppMainFlagEventNamespacedAddedListener> value)
    {
        var index = Index.Value;
        var componentPool = entity.GetComponentPool(index);
        var component = componentPool.Count > 0
            ? (MyAppMainFlagEventNamespacedAddedListenerComponent)componentPool.Pop()
            : new MyAppMainFlagEventNamespacedAddedListenerComponent();
        component.Value = value;
        entity.ReplaceComponent(index, component);
        return entity;
    }

    public static Entity RemoveFlagEventNamespacedAddedListener(this Entity entity)
    {
        entity.RemoveComponent(Index.Value);
        return entity;
    }

    public static MyAppMainFlagEventNamespacedAddedListenerComponent GetFlagEventNamespacedAddedListener(this Entity entity)
    {
        return (MyAppMainFlagEventNamespacedAddedListenerComponent)entity.GetComponent(Index.Value);
    }
}
}