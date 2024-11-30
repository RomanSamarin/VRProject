using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

public class UgadayScript : MonoBehaviour
{
    public TMP_InputField inputField;
    public TMP_Text OutPut;
    private int randomvalue;
    public void Start() {
        GenerationNumber();
    }
    
    
    public void GenerationNumber() {
         randomvalue = Random.Range(0,11);
    }
    public void OnButtonStart(){
        int value1=ReadIntFromInputField(inputField);
        
        if (value1 > randomvalue) {
            OutPut.text = "Число меньше";
        } else {
            if (value1<randomvalue) {
                OutPut.text="Число больше";
            } else {
                if (value1==randomvalue){
                    OutPut.text="Вы угадали";
                    GenerationNumber();
                }
            }
        }
    }
    
    public int ReadIntFromInputField(TMP_InputField inputField) {
        string str = inputField.text;
        if (str != null && str.Length > 0) {
            if (int.TryParse(str, out int intValue)) {
                return intValue;
            }
        }
        return 0;
    }
}
