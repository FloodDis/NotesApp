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
	public partial class AddEditForm : Form
	{
		private Note _note;
		public bool _isAddButton;
		public AddEditForm(bool isAddButton)
		{
			InitializeComponent();
			_isAddButton = isAddButton;
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void OKButton_Click(object sender, EventArgs e)
		{
			if(_isAddButton)
			{
				
			}
			_note.SetCategory((Category)AddCategoryComboBox.SelectedItem);
			_note.SetName(TitleTextBox.Text);
			_note.SetCreationTime(DateTime.Now);
		}
	}
}
