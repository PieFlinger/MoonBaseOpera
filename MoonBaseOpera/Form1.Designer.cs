namespace MoonBaseOpera
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.noteBar = new System.Windows.Forms.TrackBar();
			this.addNoteButton = new System.Windows.Forms.Button();
			this.noteDisplayBox = new System.Windows.Forms.TextBox();
			this.modBar = new System.Windows.Forms.TrackBar();
			this.displayBox = new System.Windows.Forms.TextBox();
			this.octaveBar = new System.Windows.Forms.TrackBar();
			this.intervalBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.noteBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.modBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.octaveBar)).BeginInit();
			this.SuspendLayout();
			// 
			// noteBar
			// 
			this.noteBar.LargeChange = 1;
			this.noteBar.Location = new System.Drawing.Point(12, 12);
			this.noteBar.Maximum = 6;
			this.noteBar.Name = "noteBar";
			this.noteBar.Size = new System.Drawing.Size(242, 45);
			this.noteBar.TabIndex = 0;
			this.noteBar.ValueChanged += new System.EventHandler(this.noteBar_ValueChanged);
			// 
			// addNoteButton
			// 
			this.addNoteButton.Location = new System.Drawing.Point(393, 61);
			this.addNoteButton.Name = "addNoteButton";
			this.addNoteButton.Size = new System.Drawing.Size(48, 30);
			this.addNoteButton.TabIndex = 1;
			this.addNoteButton.Text = "Add";
			this.addNoteButton.UseVisualStyleBackColor = true;
			this.addNoteButton.Click += new System.EventHandler(this.addNoteButton_Click);
			// 
			// noteDisplayBox
			// 
			this.noteDisplayBox.Enabled = false;
			this.noteDisplayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.noteDisplayBox.Location = new System.Drawing.Point(311, 12);
			this.noteDisplayBox.Name = "noteDisplayBox";
			this.noteDisplayBox.Size = new System.Drawing.Size(130, 44);
			this.noteDisplayBox.TabIndex = 2;
			// 
			// modBar
			// 
			this.modBar.LargeChange = 1;
			this.modBar.Location = new System.Drawing.Point(260, 4);
			this.modBar.Maximum = 1;
			this.modBar.Minimum = -1;
			this.modBar.Name = "modBar";
			this.modBar.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.modBar.Size = new System.Drawing.Size(45, 90);
			this.modBar.TabIndex = 3;
			this.modBar.ValueChanged += new System.EventHandler(this.modBar_ValueChanged);
			// 
			// displayBox
			// 
			this.displayBox.Location = new System.Drawing.Point(13, 100);
			this.displayBox.Multiline = true;
			this.displayBox.Name = "displayBox";
			this.displayBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.displayBox.Size = new System.Drawing.Size(428, 105);
			this.displayBox.TabIndex = 4;
			// 
			// octaveBar
			// 
			this.octaveBar.LargeChange = 1;
			this.octaveBar.Location = new System.Drawing.Point(13, 49);
			this.octaveBar.Maximum = 8;
			this.octaveBar.Name = "octaveBar";
			this.octaveBar.Size = new System.Drawing.Size(241, 45);
			this.octaveBar.TabIndex = 5;
			this.octaveBar.ValueChanged += new System.EventHandler(this.octaveBar_ValueChanged);
			// 
			// intervalBox
			// 
			this.intervalBox.Location = new System.Drawing.Point(311, 67);
			this.intervalBox.Name = "intervalBox";
			this.intervalBox.Size = new System.Drawing.Size(76, 20);
			this.intervalBox.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(453, 217);
			this.Controls.Add(this.intervalBox);
			this.Controls.Add(this.octaveBar);
			this.Controls.Add(this.displayBox);
			this.Controls.Add(this.modBar);
			this.Controls.Add(this.noteDisplayBox);
			this.Controls.Add(this.addNoteButton);
			this.Controls.Add(this.noteBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(459, 245);
			this.MinimumSize = new System.Drawing.Size(459, 245);
			this.Name = "Form1";
			this.Text = "Moonbase Alpha Music Generator";
			((System.ComponentModel.ISupportInitialize)(this.noteBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.modBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.octaveBar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TrackBar noteBar;
		private System.Windows.Forms.Button addNoteButton;
		private System.Windows.Forms.TextBox noteDisplayBox;
		private System.Windows.Forms.TrackBar modBar;
		private System.Windows.Forms.TextBox displayBox;
		private System.Windows.Forms.TrackBar octaveBar;
		private System.Windows.Forms.TextBox intervalBox;
	}
}

