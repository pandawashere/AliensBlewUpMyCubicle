using UnityEngine;
using System.Collections;
using UnityEditor;
using UnityEditorInternal;

[CustomEditor(typeof(DialogueData))]
public class DialogueDataEditor: Editor {
	SerializedProperty DialogueL;
	SerializedProperty SpeakerL;
	SerializedProperty DesicionsL;

	private void OnEnable() {
		DialogueL = serializedObject.FindProperty ("DialogueStrings");



		DesicionsL = serializedObject.FindProperty ("Desicions");



	}


	public override void OnInspectorGUI(){
		DrawDefaultInspector ();

		serializedObject.Update ();
		EditorGUILayout.LabelField("Game Data:");
		EditorGUILayout.PropertyField(serializedObject.FindProperty("DialogueStrings"));
		serializedObject.ApplyModifiedProperties();
	}
}