/*
 * Created by SharpDevelop.
 * User: t
 * Date: 11/25/2018
 * Time: 12:44 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AndFTP
{
	partial class OpenConnection
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label Server;
		private System.Windows.Forms.TextBox ServerText;
		private System.Windows.Forms.Label Username;
		private System.Windows.Forms.TextBox UsernameText;
		private System.Windows.Forms.Label Password;
		private System.Windows.Forms.TextBox PasswordText;
		private System.Windows.Forms.Label Port;
		private System.Windows.Forms.TextBox PortText;
		private System.Windows.Forms.Button Connect;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.Server = new System.Windows.Forms.Label();
			this.ServerText = new System.Windows.Forms.TextBox();
			this.Username = new System.Windows.Forms.Label();
			this.UsernameText = new System.Windows.Forms.TextBox();
			this.Password = new System.Windows.Forms.Label();
			this.PasswordText = new System.Windows.Forms.TextBox();
			this.Port = new System.Windows.Forms.Label();
			this.PortText = new System.Windows.Forms.TextBox();
			this.Connect = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Server
			// 
			this.Server.Location = new System.Drawing.Point(12, 13);
			this.Server.Name = "Server";
			this.Server.Size = new System.Drawing.Size(60, 23);
			this.Server.TabIndex = 0;
			this.Server.Text = "Server:";
			// 
			// ServerText
			// 
			this.ServerText.Location = new System.Drawing.Point(99, 14);
			this.ServerText.Name = "ServerText";
			this.ServerText.Size = new System.Drawing.Size(276, 22);
			this.ServerText.TabIndex = 1;
			// 
			// Username
			// 
			this.Username.Location = new System.Drawing.Point(12, 41);
			this.Username.Name = "Username";
			this.Username.Size = new System.Drawing.Size(81, 23);
			this.Username.TabIndex = 2;
			this.Username.Text = "Username:";
			// 
			// UsernameText
			// 
			this.UsernameText.Location = new System.Drawing.Point(99, 42);
			this.UsernameText.Name = "UsernameText";
			this.UsernameText.Size = new System.Drawing.Size(276, 22);
			this.UsernameText.TabIndex = 3;
			// 
			// Password
			// 
			this.Password.Location = new System.Drawing.Point(12, 69);
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(81, 23);
			this.Password.TabIndex = 4;
			this.Password.Text = "Password:";
			// 
			// PasswordText
			// 
			this.PasswordText.Location = new System.Drawing.Point(99, 70);
			this.PasswordText.Name = "PasswordText";
			this.PasswordText.Size = new System.Drawing.Size(276, 22);
			this.PasswordText.TabIndex = 5;
			// 
			// Port
			// 
			this.Port.Location = new System.Drawing.Point(12, 97);
			this.Port.Name = "Port";
			this.Port.Size = new System.Drawing.Size(81, 23);
			this.Port.TabIndex = 6;
			this.Port.Text = "Port:";
			// 
			// PortText
			// 
			this.PortText.Location = new System.Drawing.Point(99, 98);
			this.PortText.Name = "PortText";
			this.PortText.Size = new System.Drawing.Size(30, 22);
			this.PortText.TabIndex = 7;
			// 
			// Connect
			// 
			this.Connect.Location = new System.Drawing.Point(12, 126);
			this.Connect.Name = "Connect";
			this.Connect.Size = new System.Drawing.Size(363, 57);
			this.Connect.TabIndex = 8;
			this.Connect.Text = "Connect!";
			this.Connect.UseVisualStyleBackColor = true;
			this.Connect.Click += new System.EventHandler(this.ConnectClick);
			// 
			// OpenConnection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScrollMargin = new System.Drawing.Size(5, 5);
			this.ClientSize = new System.Drawing.Size(398, 193);
			this.Controls.Add(this.Connect);
			this.Controls.Add(this.PortText);
			this.Controls.Add(this.Port);
			this.Controls.Add(this.PasswordText);
			this.Controls.Add(this.Password);
			this.Controls.Add(this.UsernameText);
			this.Controls.Add(this.Username);
			this.Controls.Add(this.ServerText);
			this.Controls.Add(this.Server);
			this.Name = "OpenConnection";
			this.Text = "New Connection";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
