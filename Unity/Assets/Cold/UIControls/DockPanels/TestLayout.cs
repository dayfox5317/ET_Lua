using Battlehub.UIControls.Dialogs;
using Battlehub.UIControls.DockPanels;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLayout : MonoBehaviour
{
    [SerializeField]
    private DialogManager m_dialog = null;
    [SerializeField]
    private Transform m_contentPrefab = null;

    [SerializeField]
    private DockPanel m_dockPanels = null;
    [SerializeField]
    private string m_headerText = null;
    [SerializeField]
    private Sprite m_sprite = null;
    // Start is called before the first frame update
    void Start()
    {
        OnDefaultLayout();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private int m_counter;
    private void OnDefaultLayout()
    {
        Region rootRegion = m_dockPanels.RootRegion;
        rootRegion.CloseAllTabs();
        foreach (Transform child in m_dockPanels.Free)
        {
            Region region = child.GetComponent<Region>();
            region.CloseAllTabs();
        }

        LayoutInfo layout = new LayoutInfo(false,
                  CreateLayoutInfo(Instantiate(m_contentPrefab).transform, m_headerText + " " + m_counter++, m_sprite),
                  new LayoutInfo(true,
                      CreateLayoutInfo(Instantiate(m_contentPrefab).transform, m_headerText + " " + m_counter++, m_sprite),
                      CreateLayoutInfo(Instantiate(m_contentPrefab).transform, m_headerText + " " + m_counter++, m_sprite),
                      0.5f),
                  0.75f);


        m_dockPanels.RootRegion.Build(layout);
    }
    private LayoutInfo CreateLayoutInfo(Transform content, string header, Sprite icon)
    {
        Tab tab = Instantiate(m_dockPanels.TabPrefab);
        tab.Icon = icon;
        tab.Text = header;

        return new LayoutInfo(content, tab) /*{ CanClose=true,CanDrag=false}*/;
    }

}
