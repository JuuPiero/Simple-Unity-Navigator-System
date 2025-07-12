using System.Collections.Generic;
using UnityEngine;

public class ModalManager : MonoBehaviour {
    public static ModalManager Instance;
    

    [Header("Modals in Scene")]
    public List<NamedView> modalsInScene;

    // [Header("References")]
    // public Transform modalContainer;

    private Dictionary<string, ScreenBase> _modals;
    private Stack<ScreenBase> _modalStack = new();

    void Awake() {
        Instance = this;

        _modals = new();
        foreach (var pair in modalsInScene) {
            _modals[pair.name] = pair.screen;
            pair.screen.gameObject.SetActive(false);
        }
    }

    public void ShowModal(string name) {
        if (!_modals.ContainsKey(name)) {
            Debug.LogError($"Modal '{name}' không tồn tại.");
            return;
        }

        var modal = _modals[name];
        // modal.transform.SetParent(modalContainer, false);
        modal.OnEnter();
        _modalStack.Push(modal);
    }

    public void CloseModal() {
        if (_modalStack.Count == 0) return;

        var top = _modalStack.Pop();
        top.OnExit();
    }
}