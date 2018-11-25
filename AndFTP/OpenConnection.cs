/*
 * Created by SharpDevelop.
 * User: t
 * Date: 11/25/2018
 * Time: 12:44 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net;

namespace AndFTP
{
	/// <summary>
	/// Description of OpenConnection.
	/// </summary>
	
	public partial class OpenConnection : Form
	{
		public event EventHandler NewConnection;
		public String[] args = new string[4];
		
		public OpenConnection()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			PortText.Text = "21";			
		}
		void ConnectClick(object sender, EventArgs e)
		{
			args[0] = ServerText.Text;
			args[1] = UsernameText.Text;
			args[2] = PasswordText.Text;
			args[3] = PortText.Text;
			if(NewConnection != null) NewConnection(sender, e);
			this.Close();
		}
	}
}
