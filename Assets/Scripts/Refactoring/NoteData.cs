using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class NoteData : ScriptableObject
{
    public int TypeOfNotes; // type of note, like hold down, tap, light tap
    public float SpawnPointX; // spawn point coordinates
    public float SpawnPointY;
    public float SpawnPointZ;
    public float Timing; //timestamp of beat (when this is reached the type of note will be spawned)
}
