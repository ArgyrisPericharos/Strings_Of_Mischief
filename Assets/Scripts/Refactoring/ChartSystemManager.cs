using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder;

public class ChartSystemManager : MonoBehaviour
{
    public List<NoteData> ChartNoteList;
    public List<GameObject> TypeOfNoteList;
    public List<GameObject> NoteObjectsList;
    public GameManager Timer;
    public Camera MainCamera;
    // Start is called before the first frame update
    void Start()
    {
       // TypeOfNoteList.Add(new GameObject(NormalType, LightType, HoldType))
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer.TimeGoBy >= ChartNoteList[0].Timing) // needs a controling bollean
        {
            Instantiate(TypeOfNoteList[ChartNoteList[0].TypeOfNotes], new Vector3(NoteObjectsList[ChartNoteList[0].TheObjectThatHitsThis].transform.position.x, NoteObjectsList[ChartNoteList[0].TheObjectThatHitsThis].transform.position.y, NoteObjectsList[ChartNoteList[0].TheObjectThatHitsThis].transform.position.z + 1.3f), Quaternion.identity).transform.parent = MainCamera.transform;

            ChartNoteList.RemoveAt(0);
        }
    }
    //notes need to be spawned 1.3f away from the z position of the cubes
}
