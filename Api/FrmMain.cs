namespace Api
{
	using System;
	using System.Collections.Generic;
	using System.Windows.Forms;

	public partial class FrmMain : Form
	{
		public FrmMain()
		{
			InitializeComponent();
		}

		private async void BtnSendRequest_Click(object sender, EventArgs e)
		{
			ApiCaller api = new ApiCaller();

			RestRequest request = new RestRequest
			{
				Method = "GET",
				Endpoint = "",
				Parameters = new List<RestParameter>()
				{
					new RestParameter { Name = "name", Value = "turan" },
					new RestParameter { Name = "lastname", Value = "volle" }
				}
			};

			RestResponse response = await api.GetEndpoint(request);

			if (response.Status)
				TxtResults.Text = response.Response;
			else
				TxtResults.Text = $"{response.ErrorCode} - {response.Message}";
		}
	}
}