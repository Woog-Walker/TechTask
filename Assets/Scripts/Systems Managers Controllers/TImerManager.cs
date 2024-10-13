    using System.Collections;
using TechnicalTask.SaveLoad;
using TechnicalTask.UI;
using UnityEngine;
using Zenject;

namespace TechnicalTask.TimerMecha
{
    public class TimerManager : MonoBehaviour
    {
        [SerializeField] private int timerValue = 0;

        [Inject] CanvasManager canvasManager;
        [Inject] SavingManager savingManager;

        public void SetTimerValue(int incValue) => timerValue = incValue;

        public void StartTimerEngine() => StartCoroutine(TimerEngine());

        IEnumerator TimerEngine()
        {
            // SKIP 1 SECOND
            yield return new WaitForSeconds(1);

            // UPDATE TIMER VALUE
            timerValue++;

            // SAVE NEW TIME    
            savingManager.SaveTimer(timerValue);

            // UPDATE UI 
            canvasManager.UiUpdateTimer(timerValue);

            // START SYSTEM AGAIN
            StartCoroutine(TimerEngine());
        }
    }
}