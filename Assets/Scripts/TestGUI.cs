using UnityEngine;
using System.Collections;

public class TestGUI : MonoBehaviour {

	private BaseCharacterClass class1 = new BaseWarriorClass();
	private BaseCharacterClass class2 = new BaseMageClass();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		GUILayout.Label (class1.CharacterClassName);
		GUILayout.Label (class1.CharacterClassDescription);
		GUILayout.Label (class1.Intelligence.ToString()); //Number Values, not strings


		GUILayout.Label (class2.CharacterClassName);
		GUILayout.Label (class2.CharacterClassDescription);
		GUILayout.Label (class2.Intelligence.ToString()); //Number Values, not strings


	}
}
