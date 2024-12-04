using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using TMPro;
using UnityEngine;

public class ClicerSxcript : MonoBehaviour
{
    public TMP_Text Money;
    int value1=0;
    int value=1;
    public void OnButtonClick(){
        Money.text=(value+value1).ToString();
        value1=value1+1;
    }
    public void OnButtonShop(){
        if (value1>=5) {
           value1= value1-5;
           value =value+1;
        }
    }
}
