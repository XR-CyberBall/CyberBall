using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using SGCore;
using SGCore.Haptics;

public class C_Gloves_configuration:MonoBehaviour


{

    public bool testFbb = false;
    public bool testVib = false;
    public Dictionary<SGCore.Finger, float> SlidersValues;



    public HapticGlove[]  Connected_HapticsGloves()
    {
      HapticGlove[] Gloves =  SGCore.Nova.NovaGlove.GetHapticGloves(true);

        return Gloves;
    }

    public void SetFBB(HapticGlove[] Gloves, Dictionary<Finger,float> Fingers)

    {

     foreach(HapticGlove glove in Gloves)
        { foreach (KeyValuePair<Finger, float> item in  Fingers) {
                SGCore.Nova.NovaGlove.GetNovaGloves()[0].QueueFFBLevel(item.Key, item.Value);

            }
        }
    }


    public void SetVib(HapticGlove[] Gloves, Dictionary<Finger, float> Fingers)
    {
        foreach (HapticGlove glove in Gloves)
        {
            foreach (KeyValuePair<Finger, float> item in Fingers)
            {
                Debug.Log("Iam in vib " + item.Key.ToString());
                glove.QueueVibroLevel(Finger.Index, 0.5f);


            }
        }
    }
    public void Handle_Fbb()
    {
        HapticGlove[] HapGloves = Connected_HapticsGloves();
        SetFBB(HapGloves, SlidersValues);
    }

    public void Handle_Vib()
    {
        HapticGlove[] HapGloves = Connected_HapticsGloves();
        SetVib(HapGloves, SlidersValues);

    }
     void Update()
    {
        if (testFbb)
        {
            Handle_Fbb();


        }
        if (testVib)
        {

            Handle_Vib();

        }
        SGCore.Nova.NovaGlove.GetHapticGloves()[0].SendHaptics();
    }




}
