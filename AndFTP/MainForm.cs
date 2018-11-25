/*
 * Created by SharpDevelop.
 * User: t
 * Date: 11/24/2018
 * Time: 4:11 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace AndFTP
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class AndFTP : Form
	{	
		private OpenConnection OPForm = new OpenConnection();
		
		public AndFTP()
		{
			InitializeComponent();
			OPForm.NewConnection += (s, eh) => 
			{
				FtpWebRequest ftpRequest = (FtpWebRequest) WebRequest.Create(OPForm.args[0]);
				ftpRequest.Credentials = new NetworkCredential(OPForm.args[1], OPForm.args[2]);
				ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;
				FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse();
				StreamReader streamReader = new StreamReader(response.GetResponseStream());
				
				List<string> directories = new List<string>();

				string line = streamReader.ReadLine();
				listBox1.Items.Clear();
				while (!string.IsNullOrEmpty(line))
				{
    				directories.Add(line);
    				line = streamReader.ReadLine();
    				if(line != null) listBox1.Items.Add(line);
				}

				streamReader.Close();
				OPForm.Close();
				OPForm = new OpenConnection();
			};
		}
		
		void NewConnectionClick(object sender, EventArgs e) 
		{
			OPForm.Show();
		}
		
	}
}
