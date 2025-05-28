using UnityEngine;
using System.Collections.Generic;
using System;

[SerializeField]
public class NoteData
{
    public float time;
    public int lane;
}

[SerializeField]
public class NoteChart
{
    public List<NoteData> notes;
}
