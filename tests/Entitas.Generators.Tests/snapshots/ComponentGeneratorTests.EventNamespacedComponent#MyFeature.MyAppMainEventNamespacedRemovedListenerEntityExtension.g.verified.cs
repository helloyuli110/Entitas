﻿//HintName: MyFeature.MyAppMainEventNamespacedRemovedListenerEntityExtension.g.cs
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
using static global::MyFeature.MyAppMainEventNamespacedRemovedListenerComponentIndex;

namespace MyFeature
{
public static class MyAppMainEventNamespacedRemovedListenerEntityExtension
{
    public static bool HasEventNamespacedRemovedListener(this Entity entity)
    {
        return entity.HasComponent(Index.Value);
    }

    public static Entity AddEventNamespacedRemovedListener(this Entity entity, global::System.Collections.Generic.List<IMyAppMainEventNamespacedRemovedListener> value)
    {
        var index = Index.Value;
        var componentPool = entity.GetComponentPool(index);
        var component = componentPool.Count > 0
            ? (MyAppMainEventNamespacedRemovedListenerComponent)componentPool.Pop()
            : new MyAppMainEventNamespacedRemovedListenerComponent();
        component.Value = value;
        entity.AddComponent(index, component);
        return entity;
    }

    public static Entity ReplaceEventNamespacedRemovedListener(this Entity entity, global::System.Collections.Generic.List<IMyAppMainEventNamespacedRemovedListener> value)
    {
        var index = Index.Value;
        var componentPool = entity.GetComponentPool(index);
        var component = componentPool.Count > 0
            ? (MyAppMainEventNamespacedRemovedListenerComponent)componentPool.Pop()
            : new MyAppMainEventNamespacedRemovedListenerComponent();
        component.Value = value;
        entity.ReplaceComponent(index, component);
        return entity;
    }

    public static Entity RemoveEventNamespacedRemovedListener(this Entity entity)
    {
        entity.RemoveComponent(Index.Value);
        return entity;
    }

    public static MyAppMainEventNamespacedRemovedListenerComponent GetEventNamespacedRemovedListener(this Entity entity)
    {
        return (MyAppMainEventNamespacedRemovedListenerComponent)entity.GetComponent(Index.Value);
    }
}
}