using UnityEngine;
public enum TransitionType {
    None,
    Fade
    // Slide, Scale,
}
public abstract class ScreenBase : MonoBehaviour, INavigationScreen {
    public virtual void OnEnter(object param = null)
    {
        gameObject.SetActive(true);
    }
    public virtual void OnExit()
    { 
        gameObject.SetActive(false);    
    }
}