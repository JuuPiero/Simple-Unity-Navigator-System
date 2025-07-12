using UnityEngine;
using UnityEngine.UI;
public class BottomTabBar : MonoBehaviour {
    [SerializeField] private Button _homeButton;
    [SerializeField] private Button _profileButton;
    [SerializeField] private Button _settingsButton;

    void Awake() {
        _homeButton.onClick.AddListener(() => TabNavigator.Instance.SwitchTab("HomeTab"));
        _profileButton.onClick.AddListener(() => TabNavigator.Instance.SwitchTab("ProfileTab"));
        _settingsButton.onClick.AddListener(() => TabNavigator.Instance.SwitchTab("SettingsTab"));
    }
}