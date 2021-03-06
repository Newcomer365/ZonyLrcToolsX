﻿using Zony.Lib.Infrastructures.Dependency;
using Zony.Lib.Infrastructures.EventBus;
using Zony.Lib.Infrastructures.EventBus.Handlers;
using Zony.Lib.Plugin.Common;

namespace ZonyLrcTools.Events.UIEvents
{
    public class UIComponentEnableEventData : EventData
    {

    }

    public class UIComponentEnableEvent : IEventHandler<UIComponentEnableEventData>, ITransientDependency
    {
        public void HandleEvent(UIComponentEnableEventData eventData)
        {
            GlobalContext.Instance.UIContext.Top_ToolStrip_Buttons[AppConsts.Identity_Button_SearchFile].Enabled = true;
            GlobalContext.Instance.UIContext.Top_ToolStrip_Buttons[AppConsts.Identity_Button_DownLoadLyric].Enabled = true;
            GlobalContext.Instance.UIContext.Top_ToolStrip_Buttons[AppConsts.Identity_Button_DownLoadAblumImage].Enabled = true;
            GlobalContext.Instance.UIContext.Center_ListViewNF_MusicList.Enabled = true;

            GlobalContext.Instance.UIContext.Bottom_ProgressBar.Maximum = GlobalContext.Instance.MusicInfos.Count;
            GlobalContext.Instance.UIContext.Bottom_ProgressBar.Value = 0;
        }
    }
}