using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerJoin : MonoBehaviour
{
    [Header("Data Store"), Space(5)]
    public string[] userName = { "sickPlEC", "DionGLAc", "juDgLEPo", "orTiECuM", "AtMARTZI", "exhOLayw", "ComIcoNe", "HYPEaket", "ciThaRMO", "GOnoUtne", "AUtUSTRy", "BisarMiS", "HerEtINt", "rAFaLchA", "TereDlep", "ionStiRE" };


    [Header("Text Using"), Space(5)]
    public Text[] textUserName;

    [Header("Value"), Space(5)]
    public int RandomUserName;

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            for(int a = 0; a < textUserName.Length; a++)
            {
                if(textUserName[a].text == "%PlayerName%")
                {
                    RandomUserName = Random.Range(0, userName.Length);
                    textUserName[a].text = userName[RandomUserName];
                }
            }
        }
    }
}
