using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesAppUI;

public partial class AboutForm : Form
{
	public AboutForm()
	{
		InitializeComponent();
	}

	/// <summary>
	/// GitHub link
	/// </summary>
	private string _githubLink = "https://github.com/FloodDis/NotesApp";

	/// <summary>
	/// Mailbox link
	/// </summary>
	private string _emailLink = "mailto://vlad.sechenov@mail.ru";
	private void MailboxLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		ProcessStartInfo processStartInfo = new()
		{
			FileName = _emailLink,
			UseShellExecute = true
		};
		Process.Start(processStartInfo);
	}

	private void GitHubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		ProcessStartInfo processStartInfo = new()
		{
			FileName = _githubLink,
			UseShellExecute = true
		};
		Process.Start(processStartInfo);
	}
}
