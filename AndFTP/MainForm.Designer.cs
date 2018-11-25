/*
 * Created by SharpDevelop.
 * User: t
 * Date: 11/24/2018
 * Time: 4:11 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AndFTP
{
	partial class AndFTP
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button NewConnection;
		private System.Windows.Forms.ListBox listBox1;
		
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
		private void InitializeComponent()
		{
			this.NewConnection = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// NewConnection
			// 
			this.NewConnection.Location = new System.Drawing.Point(12, 12);
			this.NewConnection.Name = "NewConnection";
			this.NewConnection.Size = new System.Drawing.Size(154, 46);
			this.NewConnection.TabIndex = 0;
			this.NewConnection.Text = "New Connection";
			this.NewConnection.UseVisualStyleBackColor = true;
			this.NewConnection.Click += new System.EventHandler(this.NewConnectionClick);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(12, 65);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(800, 420);
			this.listBox1.TabIndex = 1;
			// 
			// AndFTP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(824, 505);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.NewConnection);
			this.Name = "AndFTP";
			this.Text = "AndFTP";
			this.ResumeLayout(false);

		}
	}
}
