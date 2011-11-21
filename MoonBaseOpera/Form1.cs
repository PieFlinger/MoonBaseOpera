using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MoonBaseOpera
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			updatePreview();
		}

		private void addNoteButton_Click(object sender, EventArgs e)
		{
			displayBox.Text += getCode();
		}

		private String previewGen()
		{
			String[] notes = { "A", "B", "C", "D", "E", "F", "G" };
			String[] mods = { "♭", "♮", "♯" };

			return notes[noteBar.Value] + mods[modBar.Value + 1] + " " + octaveBar.Value.ToString();
		}

		private void updatePreview()
		{
			noteDisplayBox.Text = previewGen();
		}

		private void octaveBar_ValueChanged(object sender, EventArgs e)
		{
			updatePreview();
		}

		private void noteBar_ValueChanged(object sender, EventArgs e)
		{
			updatePreview();
		}

		private void modBar_ValueChanged(object sender, EventArgs e)
		{
			updatePreview();
		}

		private String getCode()
		{
			double[] notes = { 27.50, 30.87, 16.35, 18.35, 20.60, 21.83, 24.50 };
			double freq = notes[noteBar.Value];
			freq *= Math.Pow(2, (double)modBar.Value / 12);
			freq *= Math.Pow(2, octaveBar.Value);

			return "[:t<" + ((int)Math.Round(freq)).ToString() + "," + intervalBox.Text + ">]";
		}
	}
}
