using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnketaScript : MonoBehaviour
{
    public TMP_InputField nameInputField;
    public TMP_Text nameTMPText;
     public TMP_InputField ageInputField;
     public TMP_Text ageTMPText;
    public void OnButtonUserName() {
     nameTMPText.text =nameInputField.text;
    }
    public void OnButtonAge() {
       string ageString = ageInputField.text;
        int ageInt = int.Parse(ageString);
     }
}