﻿//HintName: MyFeature.MyAppMainFlagEventNamespacedEntityExtension.g.cs
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
using static global::MyFeature.MyAppMainFlagEventNamespacedComponentIndex;

namespace MyFeature
{
public static class MyAppMainFlagEventNamespacedEntityExtension
{
    static readonly FlagEventNamespacedComponent SingleFlagEventNamespacedComponent = new FlagEventNamespacedComponent();

    public static bool HasFlagEventNamespaced(this Entity entity)
    {
        return entity.HasComponent(Index.Value);
    }

    public static Entity AddFlagEventNamespaced(this Entity entity)
    {
        entity.AddComponent(Index.Value, SingleFlagEventNamespacedComponent);
        return entity;
    }

    public static Entity ReplaceFlagEventNamespaced(this Entity entity)
    {
        entity.ReplaceComponent(Index.Value, SingleFlagEventNamespacedComponent);
        return entity;
    }

    public static Entity RemoveFlagEventNamespaced(this Entity entity)
    {
        entity.RemoveComponent(Index.Value);
        return entity;
    }

    public static FlagEventNamespacedComponent GetFlagEventNamespaced(this Entity entity)
    {
        return (FlagEventNamespacedComponent)entity.GetComponent(Index.Value);
    }
}
}