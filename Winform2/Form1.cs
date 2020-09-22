using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			customDesign();
		}

		private void customDesign()
		{
			panelMediaSubmenu.Visible = false;
			panelPlaylistSubMenu.Visible = false;
			panelToolsSubMenu.Visible = false;
		}

		private void hideSubMenu()
		{
			if (panelMediaSubmenu.Visible == true)
				panelMediaSubmenu.Visible = false;
			if (panelPlaylistSubMenu.Visible == true)
				panelPlaylistSubMenu.Visible = false;
			if (panelToolsSubMenu.Visible == true)
				panelToolsSubMenu.Visible = false;
		}

		private void showSubMenu(Panel subMenu)
		{
			if (subMenu.Visible == false)
			{
				hideSubMenu();
				subMenu.Visible = true;
			}
			else
				subMenu.Visible = false;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			showSubMenu(panelPlaylistSubMenu);
		}
		#region PlaylistSubMenu
		private void button10_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}
		#endregion

		private void btn_Media_Click(object sender, EventArgs e)
		{
			showSubMenu(panelMediaSubmenu);
		}
		#region MediaSubMenu
		private void button2_Click(object sender, EventArgs e)
		{
			openChildForm(new Form2());
			// Code for show forms
			hideSubMenu();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}
		#endregion
		

		private void btnEqualizer_Click(object sender, EventArgs e)
		{
			openChildForm(new Form3());
			hideSubMenu();
		}

		private void btnTools_Click(object sender, EventArgs e)
		{
			showSubMenu(panelToolsSubMenu);
		}
		#region ToolsSubMenu
		private void button16_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void button15_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void button14_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void button13_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}
		#endregion
		private void btnHelp_Click(object sender, EventArgs e)
		{
			hideSubMenu();
		}

		private void panel4_Paint(object sender, PaintEventArgs e)
		{

		}

		private Form activeForm = null;
		private void openChildForm(Form childForm)
		{
			if (activeForm != null)
				activeForm.Close();
			activeForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelChildForm.Controls.Add(childForm);
			panelChildForm.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}
	}
}
