using UnityEngine;
using UnityEngine.Events;

public class DanceController : MonoBehaviour
{
   [SerializeField]
   private UnityEvent OnActivateSelectDance;
   [SerializeField]
   private UnityEvent OnSelectDance;

   public void ActivateSelectDnace()
   {
    OnActivateSelectDance?.Invoke();
   }

   public void SelectDance()
   {
    OnSelectDance?.Invoke();
   }
}
