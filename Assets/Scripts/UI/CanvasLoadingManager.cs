using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace TechnicalTask.UI
{
    public class CanvasLoadingManager : MonoBehaviour
    {
        [SerializeField] TMP_Text textPersantges;
        [SerializeField] Image imageLoadingBar;

        public void UiUpdateLoadingText(float incValue) => textPersantges.text = $"{incValue}%";
        public void UiUpdateLoadingBar(float incValue) => imageLoadingBar.fillAmount = incValue;
    }
}