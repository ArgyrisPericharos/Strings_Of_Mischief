using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using WiimoteApi;

public class GuitarTesting : MonoBehaviour
{
    public GameObject green,red,blue,yellow;


    private Wiimote wiimote;

    //private Vector3 wmpOffset = Vector3.zero;
    //public GameObject APIobject;



    // Start is called before the first frame update
    void Start()
    {
        WiimoteManager.FindWiimotes();
    }

    // Update is called once per frame
    void Update()
    {
        if (!WiimoteManager.HasWiimote()) { return; }

        wiimote = WiimoteManager.Wiimotes[0];

        int ret;
         do
         {
            ret = wiimote.ReadWiimoteData();

         } while (ret > 0);

        wiimote.SendDataReportMode(InputDataType.REPORT_BUTTONS_EXT8);

        if (wiimote.current_ext == ExtensionController.GUITAR)
        {
            GuitarData data = wiimote.Guitar;

            green.gameObject.active = data.green;
            red.gameObject.active = data.red;
            yellow.gameObject.active = data.yellow;
            blue.gameObject.active = data.blue;
        }


    }


}
