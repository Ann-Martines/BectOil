using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание6WinForms
{
	/// <summary>
	/// The main class for work of the program
	/// </summary>
	public partial class Form1 : Form
	{
		/// <summary>
		/// To add to value comboBox
		/// </summary>
		public Form1()
		{
			InitializeComponent();
			this.cmbGasoline.Items.Add("DT");
			this.cmbGasoline.Items.Add("A92");
			this.cmbGasoline.Items.Add("A95");
			this.cmbGasoline.Items.Add("A95+");
			this.cmbGasoline.SelectedIndex = 0;
		}

		/// <summary>
		/// To add the price of all values
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cmbGasoline_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.cmbGasoline.SelectedIndex == 0)
				this.txtPrice.Text = "24,00";
			if (this.cmbGasoline.SelectedIndex == 1)
				this.txtPrice.Text = "25,45";
			if (this.cmbGasoline.SelectedIndex == 2)
				this.txtPrice.Text = "26,00";
			if (this.cmbGasoline.SelectedIndex == 3)
				this.txtPrice.Text = "26,45";
		}

		/// <summary>
		/// check if one radioBox works that we disconnect components for another
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void rdbQuantity_CheckedChanged(object sender, EventArgs e)
		{
			if (this.rdbQuantity.Checked)
			{
				this.numliter.ReadOnly = false;
				this.numSum.ReadOnly = true;
			}
		}

		/// <summary>
		/// check if one radioBox works that we disconnect components for another
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void rdbSum_CheckedChanged(object sender, EventArgs e)
		{
			if (this.rdbSum.Checked)
			{
				this.numSum.ReadOnly = false;
				this.numliter.ReadOnly = true;
			}
		}

		/// <summary>
		/// if checkBox that is noted it is available to editing
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void chkbHotDog_CheckedChanged(object sender, EventArgs e)
		{
			if (this.chkbHotDog.Checked)
				this.numQuantityHotDog.ReadOnly = false;
			else
				this.numQuantityHotDog.ReadOnly = true;
		}

		/// <summary>
		/// if checkBox that is noted it is available to editing
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void chkbHamburger_CheckedChanged(object sender, EventArgs e)
		{
			if (this.chkbHamburger.Checked)
				this.numQuantityHamburger.ReadOnly = false;
			else
				this.numQuantityHamburger.ReadOnly = true;
		}

		/// <summary>
		/// if checkBox that is noted it is available to editing
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void chkbСhips_CheckedChanged(object sender, EventArgs e)
		{
			if (this.chkbСhips.Checked)
				this.numQuantityChips.ReadOnly = false;
			else
				this.numQuantityChips.ReadOnly = true;
		}

		/// <summary>
		/// if checkBox that is noted it is available to editing
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void chkbCola_CheckedChanged(object sender, EventArgs e)
		{
			if (this.chkbCola.Checked)
				this.numQuantityCola.ReadOnly = false;
			else
				this.numQuantityCola.ReadOnly = true;
		}

		/// <summary>
		/// To blurt out calculation of gas station, cafe and the total cost
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
		{
			grpbFilingStation_Enter(sender, e);
			grpbCafe_Enter(sender, e);
			if (this.rdbSum.Checked)
			{
				this.lbPayAll.Text = ((float)this.numSum.Value + float.Parse(this.lbPayCafe.Text)).ToString();
			}
			else
				this.lbPayAll.Text = (float.Parse(this.lbPayStation.Text) + float.Parse(this.lbPayCafe.Text)).ToString();
			this.timer1.Start();
		}

		/// <summary>
		/// To blurt out calculation of payment of petrol gas station
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void grpbFilingStation_Enter(object sender, EventArgs e)
		{
			if (this.rdbQuantity.Checked)
			{
				this.lbPayStation.Text = "00,00";
				this.grpbPayStation.Text = "For payment";
				this.lbForPayStation.Text = "UAH";
				this.lbPayStation.Text = (float.Parse(this.txtPrice.Text) * float.Parse(this.numliter.Text)).ToString();
			}
			
			if (this.rdbSum.Checked)
			{
				this.lbPayStation.Text = "00,00";
				this.grpbPayStation.Text = "To delivery";
				this.lbForPayStation.Text = "liter";
				this.lbPayStation.Text = (float.Parse(this.numSum.Text) / float.Parse(this.txtPrice.Text)).ToString();
			}
		}

		/// <summary>
		/// To blurt out calculation of payment of cafe
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void grpbCafe_Enter(object sender, EventArgs e)
		{
			float sum = 0;
			if (this.chkbHotDog.Checked)
				sum += float.Parse(this.txtbPriceHotDog.Text) * (float)this.numQuantityHotDog.Value;
			if (this.chkbHamburger.Checked)
				sum += float.Parse(this.txtbPriceHamburger.Text) * (float)this.numQuantityHamburger.Value;
			if (this.chkbСhips.Checked)
				sum += float.Parse(this.txtbPriceChips.Text) * (float)this.numQuantityChips.Value;
			if (this.chkbCola.Checked)
				sum += float.Parse(this.txtbPriceCola.Text) * (float)this.numQuantityCola.Value;
			this.lbPayCafe.Text = sum.ToString();
		}

		/// <summary>
		/// To install the timer for inquiry, to clean a form or not
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void timer1_Tick(object sender, EventArgs e)
		{
			var ask = MessageBox.Show("To clean a form?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (ask == DialogResult.No)
				this.timer1.Interval = 10000;
			if (ask == DialogResult.Yes)
			{
				this.numliter.Value = 0;
				this.numSum.Value = 0;
				this.numQuantityHotDog.Value = 1;
				this.numQuantityHamburger.Value = 1;
				this.numQuantityHotDog.Value = 1;
				this.numQuantityHotDog.Value = 1;
				this.lbPayStation.Text = "00,00";
				this.lbPayCafe.Text = "00,00";
				this.lbPayAll.Text = "00,00";
				foreach(var i in this.grpbCafe.Controls.OfType<CheckBox>())
				{
					if (i.Checked)
						i.Checked = false;
				}
				this.timer1.Stop();
			}
		}
	}
}
