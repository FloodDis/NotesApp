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
		public bool _isAddButton;

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

		private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutForm form = new AboutForm();
			form.ShowDialog();
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			_isAddButton = true;
			AddEditForm form = new AddEditForm(_isAddButton);
			form.ShowDialog(this);
		}

		private void EditButton_Click(object sender, EventArgs e)
		{
			_isAddButton = false;
			AddEditForm form = new AddEditForm(_isAddButton);
			form.ShowDialog(this);
		}
	}
}
