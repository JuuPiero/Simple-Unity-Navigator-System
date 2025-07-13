
using UnityEngine;
using UnityEngine.UI;

public class SettingsScreen : ScreenBase
{
    [SerializeField] private Button _backButton;


    protected override void Awake()
    {
        _backButton?.onClick.AddListener(() =>
        {
            Navigation.Stack.GoBack();
        });
    }
}