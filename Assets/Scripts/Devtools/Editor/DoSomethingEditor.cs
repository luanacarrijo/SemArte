using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Template.Game
{
    [CustomEditor(typeof(DoSomething))]
    public class DoSomethingEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            if (GUILayout.Button("Invoke"))
            {
                if (target is DoSomething ds)
                    ds.events.Invoke();
            }
        }
    }
}
