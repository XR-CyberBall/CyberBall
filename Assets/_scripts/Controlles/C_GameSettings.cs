using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class C_GameSettings:MonoBehaviour
{
    public TMP_InputField _GameIteration;
    public TMP_Dropdown _Dropdown__GameIteration;
    public void Update_Settings()
    {

        TMP_Dropdown.OptionData Selected_option = _Dropdown__GameIteration.options[_Dropdown__GameIteration.value];

        int Selected_Iteration = _Dropdown__GameIteration.value;

        PlayerPrefs.SetInt(Enums.PrefKeys.ITERATION.ToString(), Selected_Iteration);
   

    }

  
    public   E_Setting Get_Settings() 
    {

        int Irretation = PlayerPrefs.GetInt(Enums.PrefKeys.ITERATION.ToString(),0);
       
        E_Setting Est = new E_Setting();
        Est.itterationNumber = Irretation;
        return Est;

    }


    public void Set_Settings_view()
    {

        _Dropdown__GameIteration.value = Get_Settings().itterationNumber;
    }
  

}
