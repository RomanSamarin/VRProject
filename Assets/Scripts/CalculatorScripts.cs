using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CalculatorScripts : MonoBehaviour
{
    public TMP_InputField LeftInputField;

    public TMP_InputField RightInputField;

    public TMP_Text OutPut;

    public void OnButtonMinus() {
        float  value1 =ReadIntFromInputField(LeftInputField);
        float  value2 =ReadIntFromInputField(RightInputField);
        OutPut.text = (value1-value2).ToString();
    }
    public void OnPlusButton() {
        float  value1 =ReadIntFromInputField(LeftInputField);
        float  value2 =ReadIntFromInputField(RightInputField);
        OutPut.text =(value1+value2).ToString(); 
    }
    public void OnButtonDelenie() {
        float  value1 =ReadIntFromInputField(LeftInputField);
        float  value2 =ReadIntFromInputField(RightInputField); 
        if (value2 == 0) {
            OutPut.text= "Нельзя делить на 0"; 
        } else {
            OutPut.text =(value1/value2).ToString();
        }
    }
    public void OnButtonUmnohenie() {
        float  value1 =ReadIntFromInputField(LeftInputField);
        float  value2 =ReadIntFromInputField(RightInputField);
        OutPut.text =(value1*value2).ToString();
    }
    public float ReadIntFromInputField(TMP_InputField inputField) {
        string str = inputField.text;
        if (str != null && str.Length > 0) {
            if (float.TryParse(str, out float floatValue)) {
                return floatValue;
            }
        }
        return 0;  
    }
}
