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
			CategoryComboBox.Items.Add(Category.All);
			CategoryComboBox.Items.Add(Category.Documents);
			CategoryComboBox.Items.Add(Category.Finances);
			CategoryComboBox.Items.Add(Category.HealthAndSport);
			CategoryComboBox.Items.Add(Category.Home);
			CategoryComboBox.Items.Add(Category.People);
			CategoryComboBox.Items.Add(Category.Work);
			CategoryComboBox.Items.Add(Category.Other);
		}
	}
}
