using UnityEngine;
using UnityEngine.Events;

public class DanceController : MonoBehaviour
{
   [SerializeField]
   private UnityEvent OnActivateSelectDance;
   [SerializeField]
   private UnityEvent OnSelectDance;
   [SerializeField]
   private Animator CharacterAnimator;
   [SerializeField]
   private NotesManager notesManager;
   private SoundData CurrentSoundData;

   public void ActivateSelectDnace()
   {
      OnActivateSelectDance?.Invoke();
   }

   public void SelectDance(SoundData soundData)
   {
      CurrentSoundData = soundData;
      OnSelectDance?.Invoke();
   }

   public void StarDance()
   {
      CharacterAnimator.Play(CurrentSoundData.danceName);
      SoundManager.instance.PlayMusic(CurrentSoundData.musicName);
      notesManager.StartNotes(CurrentSoundData.notesConfig, CurrentSoundData.Speed);
   }
}
