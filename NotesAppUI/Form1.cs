using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NotesAppUI
{
	public partial class NotesAppUIForm : Form
	{
		public NotesAppUIForm()
		{
			InitializeComponent();
		}

		private void NotesAppUIForm_Load(object sender, EventArgs e)
		{
			CategoryComboBox.Items.Add("All");
			CategoryComboBox.Items.Add("Work");
			CategoryComboBox.Items.Add("Home");
			CategoryComboBox.Items.Add("Health and sport");
			CategoryComboBox.Items.Add("People");
			CategoryComboBox.Items.Add("Documents");
			CategoryComboBox.Items.Add("Finances");
			CategoryComboBox.Items.Add("Other");
		}
	}
}
