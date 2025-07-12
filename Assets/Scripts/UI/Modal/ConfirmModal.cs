using UnityEngine;
using UnityEngine.UI;

public class ConfirmModal : ScreenBase
{
    [SerializeField] private Button yesButton;
    [SerializeField] private Button noButton;


    // [SerializeField] private GameObject _overlay;

    void Awake()
    {
        yesButton?.onClick.AddListener(() =>
        {
            ModalManager.Instance.CloseModal();
        });

    }
}