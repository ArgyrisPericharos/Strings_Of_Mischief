using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder;

public class ChartSystemManager : MonoBehaviour
{
    public List<NoteData> ChartNoteList;
    public List<GameObject> TypeOfNoteList;
    public float TimeGoBy;
    // Start is called before the first frame update
    void Start()
    {
       // TypeOfNoteList.Add(new GameObject(NormalType, LightType, HoldType))
    }

    // Update is called once per frame
    void Update()
    {
        TimeGoBy =+ Time.deltaTime;

        if(TimeGoBy >= ChartNoteList[0].Timing) // needs a controling bollean
        {
            Instantiate(TypeOfNoteList[ChartNoteList[0].TypeOfNotes], new Vector3(ChartNoteList[0].SpawnPointX, ChartNoteList[0].SpawnPointY, ChartNoteList[0].SpawnPointZ), Quaternion.identity);
            ChartNoteList.RemoveAt(0);
        }
    }
}
