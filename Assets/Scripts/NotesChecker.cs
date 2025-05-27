using System.Collections.Generic;
using UnityEngine;

public class NotesChecker : MonoBehaviour
{
    private List<GameObject> notes = new List<GameObject>();
    private void OTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Note"))
        {
            notes.Add(collision.gameObject);
        }
    }

    private void OTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Note"))
        {
            notes.Remove(collision.gameObject);
        }
    }

    public void DestroyNotes()
    {
        while (notes.Count > 0)
        {
            GameObject note = notes[0];
            notes.RemoveAt(0);
            Destroy(note);
        }
        notes.Clear();
    }
}
