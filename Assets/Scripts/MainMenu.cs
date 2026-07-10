using UnityEngine;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private UIDocument m_HUDView;

    private UIDocument m_menuUiDocument;
    private VisualElement m_TopMostVisualElement;
    private Button m_StartButton;
    private Button m_CreditsButton;
    private Button m_AboutUsButton;

    private void Start()
    {
        m_menuUiDocument = GetComponent<UIDocument>();
        m_TopMostVisualElement = m_menuUiDocument.rootVisualElement;

        // can retrieve the various elements from the UI document/a parent element via their name and type, very similar to get component
        // a UI document can act as another visual element within the UI hierarchy, so you can recreate a very similar UI layer system
        // inidividual documents can be hidden/shown as needed or removed from the hierarchy
        m_StartButton = m_TopMostVisualElement.Q<Button>("startgame__button");
        m_CreditsButton = m_TopMostVisualElement.Q<Button>("credits__button");
        m_AboutUsButton = m_TopMostVisualElement.Q<Button>("about-us__button");

        m_StartButton.RegisterCallback<ClickEvent>(ClickPlayButton);
    }

    private void ClickPlayButton(ClickEvent clickEvent)
    {
        Debug.Log("Clicked play button");
        m_TopMostVisualElement.style.display = DisplayStyle.None;
        //m_menuUiDocument.enabled = false;
        //m_HUDView.enabled = true;
    }
}
