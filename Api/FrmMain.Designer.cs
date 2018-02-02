namespace Api
{
	partial class FrmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.BtnSendRequest = new System.Windows.Forms.Button();
			this.TxtResults = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// BtnSendRequest
			// 
			this.BtnSendRequest.Location = new System.Drawing.Point(13, 13);
			this.BtnSendRequest.Name = "BtnSendRequest";
			this.BtnSendRequest.Size = new System.Drawing.Size(675, 36);
			this.BtnSendRequest.TabIndex = 0;
			this.BtnSendRequest.Text = "SEND REQUEST";
			this.BtnSendRequest.UseVisualStyleBackColor = true;
			this.BtnSendRequest.Click += new System.EventHandler(this.BtnSendRequest_Click);
			// 
			// TxtResults
			// 
			this.TxtResults.Location = new System.Drawing.Point(13, 65);
			this.TxtResults.Multiline = true;
			this.TxtResults.Name = "TxtResults";
			this.TxtResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.TxtResults.Size = new System.Drawing.Size(675, 296);
			this.TxtResults.TabIndex = 1;
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 373);
			this.Controls.Add(this.TxtResults);
			this.Controls.Add(this.BtnSendRequest);
			this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmMain";
			this.Text = "Api Call";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnSendRequest;
		private System.Windows.Forms.TextBox TxtResults;
	}
}

