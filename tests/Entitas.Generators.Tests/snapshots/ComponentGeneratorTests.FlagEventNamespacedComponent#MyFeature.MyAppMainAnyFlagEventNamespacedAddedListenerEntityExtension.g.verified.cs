﻿//HintName: MyFeature.MyAppMainAnyFlagEventNamespacedAddedListenerEntityExtension.g.cs
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
using static global::MyFeature.MyAppMainAnyFlagEventNamespacedAddedListenerComponentIndex;

namespace MyFeature
{
public static class MyAppMainAnyFlagEventNamespacedAddedListenerEntityExtension
{
    public static bool HasAnyFlagEventNamespacedAddedListener(this Entity entity)
    {
        return entity.HasComponent(Index.Value);
    }

    public static Entity AddAnyFlagEventNamespacedAddedListener(this Entity entity, global::System.Collections.Generic.List<IMyAppMainAnyFlagEventNamespacedAddedListener> value)
    {
        var index = Index.Value;
        var componentPool = entity.GetComponentPool(index);
        var component = componentPool.Count > 0
            ? (MyAppMainAnyFlagEventNamespacedAddedListenerComponent)componentPool.Pop()
            : new MyAppMainAnyFlagEventNamespacedAddedListenerComponent();
        component.Value = value;
        entity.AddComponent(index, component);
        return entity;
    }

    public static Entity ReplaceAnyFlagEventNamespacedAddedListener(this Entity entity, global::System.Collections.Generic.List<IMyAppMainAnyFlagEventNamespacedAddedListener> value)
    {
        var index = Index.Value;
        var componentPool = entity.GetComponentPool(index);
        var component = componentPool.Count > 0
            ? (MyAppMainAnyFlagEventNamespacedAddedListenerComponent)componentPool.Pop()
            : new MyAppMainAnyFlagEventNamespacedAddedListenerComponent();
        component.Value = value;
        entity.ReplaceComponent(index, component);
        return entity;
    }

    public static Entity RemoveAnyFlagEventNamespacedAddedListener(this Entity entity)
    {
        entity.RemoveComponent(Index.Value);
        return entity;
    }

    public static MyAppMainAnyFlagEventNamespacedAddedListenerComponent GetAnyFlagEventNamespacedAddedListener(this Entity entity)
    {
        return (MyAppMainAnyFlagEventNamespacedAddedListenerComponent)entity.GetComponent(Index.Value);
    }
}
}