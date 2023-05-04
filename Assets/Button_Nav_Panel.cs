using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Nav_Panel :MonoBehaviour
{
    public MenuManager _Manager;
    
    public Enums.Navs_Lanels _Button_Nav_laebl;

    public void Desactivate_Panel()
    {

        _Manager.DesactivatePanels(this._Button_Nav_laebl);


    }
   
  
}
