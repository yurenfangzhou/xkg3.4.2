using ASPNET.WebControls;
using ControlPanel.WeiBo;
using Hidistro.Core;
using Hidistro.Core.Entities;
using Hidistro.UI.ControlPanel.Utility;
using System;
using System.Web.UI.WebControls;

namespace Hidistro.UI.Web.Admin.Shop
{
	public class Concerned : AdminPage
	{
		protected bool _enable;

		protected System.Web.UI.WebControls.Repeater repreply;

		protected Pager pager;

		protected Concerned() : base("m07", "wbp07")
		{
		}

		protected void Page_Load(object sender, System.EventArgs e)
		{
			if (!base.IsPostBack)
			{
				SiteSettings masterSettings = SettingsManager.GetMasterSettings(false);
				this._enable = masterSettings.SubscribeReply;
				this.bind();
			}
		}

		public void bind()
		{
			this.repreply.DataSource = WeiboHelper.GetReplyTypeInfo(2);
			this.repreply.DataBind();
		}
	}
}
