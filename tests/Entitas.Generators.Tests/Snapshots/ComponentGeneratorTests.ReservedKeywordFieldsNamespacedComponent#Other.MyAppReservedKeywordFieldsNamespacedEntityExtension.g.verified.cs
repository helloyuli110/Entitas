﻿//HintName: Other.MyAppReservedKeywordFieldsNamespacedEntityExtension.g.cs
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by
//     Entitas.Generators.ComponentGenerator.EntityExtension
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Other
{
public static class MyAppReservedKeywordFieldsNamespacedEntityExtension
{
    public static bool HasReservedKeywordFieldsNamespaced(this Entity entity)
    {
        return entity.HasComponent(MyAppReservedKeywordFieldsNamespacedComponentIndex.Value);
    }

    public static Entity AddReservedKeywordFieldsNamespaced(this Entity entity, string @namespace, string @class, string @public)
    {
        var index = MyAppReservedKeywordFieldsNamespacedComponentIndex.Value;
        var component = (MyApp.ReservedKeywordFieldsNamespacedComponent)entity.CreateComponent(index, typeof(MyApp.ReservedKeywordFieldsNamespacedComponent));
        component.Namespace = @namespace;
        component.Class = @class;
        component.Public = @public;
        entity.AddComponent(index, component);
        return entity;
    }

    public static Entity ReplaceReservedKeywordFieldsNamespaced(this Entity entity, string @namespace, string @class, string @public)
    {
        var index = MyAppReservedKeywordFieldsNamespacedComponentIndex.Value;
        var component = (MyApp.ReservedKeywordFieldsNamespacedComponent)entity.CreateComponent(index, typeof(MyApp.ReservedKeywordFieldsNamespacedComponent));
        component.Namespace = @namespace;
        component.Class = @class;
        component.Public = @public;
        entity.ReplaceComponent(index, component);
        return entity;
    }

    public static Entity RemoveReservedKeywordFieldsNamespaced(this Entity entity)
    {
        entity.RemoveComponent(MyAppReservedKeywordFieldsNamespacedComponentIndex.Value);
        return entity;
    }
}
}
