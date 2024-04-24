using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class NoteData : ScriptableObject
{
    public int TypeOfNotes; // type of note, like hold down, tap, light tap
    public int TheObjectThatHitsThis;

    public float Timing; //timestamp of beat (when this is reached the type of note will be spawned)
    public Color ColourIdentifier; // Green left, Red Next, yellow Next, Blue Last;

    public float SpawnPozitionModifierZ; //1.3 is the default, after that should be calculated
}
