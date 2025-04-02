using System;
using UnityEditor;
using UnityEngine;

namespace Dt.VisualBehaviour.Editor
{
    public static class NodeHierarchyCreator
    {
        public static void Create(MenuCommand menuCommand,
            string typeName, string assemblyName = "Dt.VisualBehaviour")
        {
            GameObject go = new GameObject(typeName.Split('.').Last());
            Type type = Type.GetType($"{typeName}, {assemblyName}");
            go.AddComponent(type);
            GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);
            Undo.RegisterCreatedObjectUndo(go, go.GetInstanceID().ToString());
            Selection.activeObject = go;
        }
    }
}