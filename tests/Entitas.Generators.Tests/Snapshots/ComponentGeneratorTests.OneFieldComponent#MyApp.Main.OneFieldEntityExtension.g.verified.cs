﻿//HintName: MyApp.Main.OneFieldEntityExtension.g.cs
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by
//     Entitas.Generators.ComponentGenerator.EntityExtension
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace MyApp.Main
{
public static class OneFieldEntityExtension
{
    public static bool HasOneField(this Entity entity)
    {
        return entity.HasComponent(OneFieldComponentIndex.Value);
    }

    public static Entity AddOneField(this Entity entity, string value)
    {
        var index = OneFieldComponentIndex.Value;
        var component = (OneFieldComponent)entity.CreateComponent(index, typeof(OneFieldComponent));
        component.Value = value;
        entity.AddComponent(index, component);
        return entity;
    }

    public static Entity ReplaceOneField(this Entity entity, string value)
    {
        var index = OneFieldComponentIndex.Value;
        var component = (OneFieldComponent)entity.CreateComponent(index, typeof(OneFieldComponent));
        component.Value = value;
        entity.ReplaceComponent(index, component);
        return entity;
    }

    public static Entity RemoveOneField(this Entity entity)
    {
        entity.RemoveComponent(OneFieldComponentIndex.Value);
        return entity;
    }

    public static OneFieldComponent GetOneField(this Entity entity)
    {
        return (OneFieldComponent)entity.GetComponent(OneFieldComponentIndex.Value);
    }

    public static void Deconstruct(this OneFieldComponent component, out string value)
    {
        value = component.Value;
    }
}
}
