using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OpenByHand : MonoBehaviour
{
    public TMP_Dropdown dropdown;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)) {
             

            dropdown.Show(); ;
        } ;

        if (Input.GetKeyDown(KeyCode.S ) && dropdown.IsExpanded)
        {

        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && dropdown.IsExpanded)
        {
            int currentValue = dropdown.value;
            // Increment the value
            currentValue++;
            // Check if we've gone past the end of the options list
            if (currentValue >= dropdown.options.Count)
            {
                // Wrap around to the beginning
                currentValue = 0;
            }
            // Set the new value
            dropdown.value = currentValue;
        }
    }
}
