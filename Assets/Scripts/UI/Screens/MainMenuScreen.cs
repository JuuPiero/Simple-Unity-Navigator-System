
using UnityEngine;
using UnityEngine.UI;

public class MainMenuScreen : ScreenBase
{
    [SerializeField] private Button _settingsButton;
    [SerializeField] private Button _openModalButton;



    void Awake()
    {
        _settingsButton.onClick.AddListener(() =>
        {
            StackNavigator.Instance?.Navigate("SettingsScreen");
        });

        _openModalButton?.onClick.AddListener(() =>
        {
            ModalManager.Instance?.ShowModal("ConfirmModal");
        });
    }
}