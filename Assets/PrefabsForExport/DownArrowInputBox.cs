using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DownArrowInputBox : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager gamemanager;
    // Start is called before the first frame update

    public GameObject DataFinder;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("Iam" + other.gameObject.name);

        if (other.gameObject.tag == "Arrows")
        {
            if (DataFinder.GetComponent<WiimoteDemo>().StrumIsDown == true || DataFinder.GetComponent<WiimoteDemo>().StrumIsUp == true)
            {
                Debug.Log("Hit");
                Destroy(other.gameObject);
                gamemanager.CrowdSatisfaction += 5;
                // gamemanagerscript.GetComponent<GameManager>().HitNotes += 1;
                // gamemanagerscript.GetComponent<GameManager>().ListOfWordFields[0].GetComponent<TextMeshProUGUI>().color = Color.white;
                // gamemanagerscript.GetComponent<GameManager>().ListOfWordFields.RemoveAt(0);
            }
       

        }
    }
}
