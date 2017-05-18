using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class DialogueData : MonoBehaviour {
	public Text _textComponent;

	public string[] DialogueStrings;

	public KeyCode DialogueInput = KeyCode.Mouse0;

	private bool _isEndOfDialogue = false;
	private bool _isDialogueActive = true;
	public GameObject Choices;

	public GameObject char1;
	public Sprite[] character1;
	public GameObject char2;
	public Sprite[] character2;
	public GameObject char3;
	public Sprite[] character3;
	public GameObject char4;
	public Sprite[] character4;

	private int currentDialogueLine;

	void Start () {
		_textComponent = GetComponent<Text> ();
		_textComponent.text = "";
	}

	void Update ()
	{
		if (_isDialogueActive && currentDialogueLine < DialogueStrings.Length -1 && Input.GetKeyDown(KeyCode.Mouse0)) { 
				currentDialogueLine++;

		}
		if (currentDialogueLine == DialogueStrings.Length -1) {
			_isEndOfDialogue = true;
			ShowChoices ();
			_isDialogueActive = false;
			}
		_textComponent.text = DialogueStrings [currentDialogueLine];
		char1.GetComponent<SpriteRenderer>().sprite = character1[currentDialogueLine];
		char2.GetComponent<SpriteRenderer>().sprite = character2[currentDialogueLine];
		char3.GetComponent<SpriteRenderer>().sprite = character3[currentDialogueLine];
		char4.GetComponent<SpriteRenderer>().sprite = character4[currentDialogueLine];
	}

	private void ShowChoices ()
	{
		if (_isEndOfDialogue == true) {
			Choices.SetActive (true);
		}
	}
}

	