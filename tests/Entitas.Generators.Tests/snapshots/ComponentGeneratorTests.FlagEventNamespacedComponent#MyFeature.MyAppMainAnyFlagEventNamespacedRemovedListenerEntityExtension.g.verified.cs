﻿//HintName: MyFeature.MyAppMainAnyFlagEventNamespacedRemovedListenerEntityExtension.g.cs
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
using static global::MyFeature.MyAppMainAnyFlagEventNamespacedRemovedListenerComponentIndex;

namespace MyFeature
{
public static class MyAppMainAnyFlagEventNamespacedRemovedListenerEntityExtension
{
    public static bool HasAnyFlagEventNamespacedRemovedListener(this Entity entity)
    {
        return entity.HasComponent(Index.Value);
    }

    public static Entity AddAnyFlagEventNamespacedRemovedListener(this Entity entity, global::System.Collections.Generic.List<IMyAppMainAnyFlagEventNamespacedRemovedListener> value)
    {
        var index = Index.Value;
        var componentPool = entity.GetComponentPool(index);
        var component = componentPool.Count > 0
            ? (MyAppMainAnyFlagEventNamespacedRemovedListenerComponent)componentPool.Pop()
            : new MyAppMainAnyFlagEventNamespacedRemovedListenerComponent();
        component.Value = value;
        entity.AddComponent(index, component);
        return entity;
    }

    public static Entity ReplaceAnyFlagEventNamespacedRemovedListener(this Entity entity, global::System.Collections.Generic.List<IMyAppMainAnyFlagEventNamespacedRemovedListener> value)
    {
        var index = Index.Value;
        var componentPool = entity.GetComponentPool(index);
        var component = componentPool.Count > 0
            ? (MyAppMainAnyFlagEventNamespacedRemovedListenerComponent)componentPool.Pop()
            : new MyAppMainAnyFlagEventNamespacedRemovedListenerComponent();
        component.Value = value;
        entity.ReplaceComponent(index, component);
        return entity;
    }

    public static Entity RemoveAnyFlagEventNamespacedRemovedListener(this Entity entity)
    {
        entity.RemoveComponent(Index.Value);
        return entity;
    }

    public static MyAppMainAnyFlagEventNamespacedRemovedListenerComponent GetAnyFlagEventNamespacedRemovedListener(this Entity entity)
    {
        return (MyAppMainAnyFlagEventNamespacedRemovedListenerComponent)entity.GetComponent(Index.Value);
    }
}
}