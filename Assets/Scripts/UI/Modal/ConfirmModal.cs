using UnityEngine;
using UnityEngine.UI;

public class ConfirmModal : ScreenBase
{
    [SerializeField] private Button yesButton;
    [SerializeField] private Button noButton;


    // [SerializeField] private GameObject _overlay;

    protected override void Awake()
    {
        yesButton?.onClick.AddListener(() =>
        {
            Navigation.Modal.CloseModal();
        });

    }
}