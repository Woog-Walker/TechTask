using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace TechnicalTask.UI
{
    public class CanvasManager : MonoBehaviour
    {
        [Header("TIMER")]
        [SerializeField] TMP_Text gameTimerStatus;

        [Header("UI PANELS")]
        [SerializeField] Transform loadingPanel;
        [SerializeField] Transform timerPanel;

        // TIMER
        public void UiUpdateTimer(int totalSeconds)
        {
            // Format the time as HH:MM:SS
            string timeFormatted = string.Format(
                "{0:00}:{1:00}:{2:00}", 
                totalSeconds / 3600, 
                (totalSeconds % 3600) / 60, 
                totalSeconds % 60);

            gameTimerStatus.text = timeFormatted;
        }

        // PANEL TIMER
        public void UiPanelTimerEnable() => timerPanel.gameObject.SetActive(true);
        public void UiPanelTimerDisable() => timerPanel.gameObject.SetActive(false);
    }
}