using System.Collections;
using TechnicalTask.SaveLoad;
using TechnicalTask.UI;
using UnityEngine;
using Zenject;

namespace TechnicalTask.TimerMecha
{
    public class FlowManager : MonoBehaviour
    {
        [Inject] SavingManager savingManager;
        [Inject] CanvasManager canvasManager;
        [Inject] TimerManager timerManagers;
        [Inject] GameDataManager gameDataManager;

        int currentTime = 0;

        private void Start() => CallStartFuncs();

        void CallStartFuncs()
        {
            StartTimerEngine();
            StartCoroutine(DelayToLoadStartObject());
        }

        void StartTimerEngine()
        {
            // SET TIMER SYSTEM TO LOADED VALUE
            timerManagers.SetTimerValue(savingManager.LoadTimer());

            // START FLOW TIMER
            timerManagers.StartTimerEngine();

            // SET TI UI
            canvasManager.UiUpdateTimer(currentTime);
        }


        IEnumerator DelayToLoadStartObject()
        {
            yield return new WaitForSeconds(1);

            gameDataManager.CreateDataObject(savingManager.LoadTimer());
        }
    }
}