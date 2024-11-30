using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SravnenieScripts : MonoBehaviour
{
    public TMP_InputField LeftInputField;
    public TMP_InputField RightInputField;
    public TMP_Text OutPut;
    public void OnButtonSravnenie() {
        int value1= ReadIntFromInputField(LeftInputField);
        int value2=ReadIntFromInputField(RightInputField);
        if (value1>value2) {
            OutPut.text=(value1).ToString();
        } else {
            if (value1<value2) {
            OutPut.text=(value2).ToString();
            } else{
                if(value1==value2){
                 OutPut.text="Числа равны";
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
