using UnityEngine;
using UnityEngine.UI;
public class BottomTabBar : MonoBehaviour {
    [SerializeField] private Button _homeButton;
    [SerializeField] private Button _profileButton;
    [SerializeField] private Button _settingsButton;

    void Awake() {
        _homeButton.onClick.AddListener(() => Navigation.Tab.SwitchTab("HomeTab"));
        _profileButton.onClick.AddListener(() => Navigation.Tab.SwitchTab("ProfileTab"));
        _settingsButton.onClick.AddListener(() => Navigation.Tab.SwitchTab("SettingsTab"));
    }
}