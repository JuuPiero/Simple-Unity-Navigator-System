
using UnityEngine;
using UnityEngine.UI;

public class MainMenuScreen : ScreenBase
{
    [SerializeField] private Button _settingsButton;
    [SerializeField] private Button _openModalButton;


    protected override void Awake()
    {
        _settingsButton.onClick.AddListener(() =>
        {
            Navigation.Stack.Navigate("SettingsScreen");
        });

        _openModalButton?.onClick.AddListener(() =>
        {
            Navigation.Modal?.ShowModal("ConfirmModal");
        });
    }
}