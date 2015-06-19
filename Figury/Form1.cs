using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Figury
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmG³ówny : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnOtwórz;
		private System.Windows.Forms.Button btnZapisz;
		private System.Windows.Forms.Button btnKoniec;
		private System.Windows.Forms.Panel pnlPanel;
		private System.Windows.Forms.PictureBox picObrazek;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbLinia;
		private System.Windows.Forms.RadioButton rbProstok¹t;
		private System.Windows.Forms.RadioButton rbOkr¹g;
		private System.Windows.Forms.RadioButton rbNic;

		private CDrawing drawing;
		private System.Windows.Forms.OpenFileDialog ofdOtwórz;
		private System.Windows.Forms.SaveFileDialog sfdZapisz;

		private CCoordinate punkt;

		/// <summary>
		/// Konstruktor g³ównego formularza
		/// </summary>
		public frmG³ówny()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			
			drawing=new CDrawing();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pnlPanel = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbNic = new System.Windows.Forms.RadioButton();
			this.rbOkr¹g = new System.Windows.Forms.RadioButton();
			this.rbProstok¹t = new System.Windows.Forms.RadioButton();
			this.rbLinia = new System.Windows.Forms.RadioButton();
			this.btnKoniec = new System.Windows.Forms.Button();
			this.btnZapisz = new System.Windows.Forms.Button();
			this.btnOtwórz = new System.Windows.Forms.Button();
			this.picObrazek = new System.Windows.Forms.PictureBox();
			this.ofdOtwórz = new System.Windows.Forms.OpenFileDialog();
			this.sfdZapisz = new System.Windows.Forms.SaveFileDialog();
			this.pnlPanel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlPanel
			// 
			this.pnlPanel.Controls.Add(this.groupBox1);
			this.pnlPanel.Controls.Add(this.btnKoniec);
			this.pnlPanel.Controls.Add(this.btnZapisz);
			this.pnlPanel.Controls.Add(this.btnOtwórz);
			this.pnlPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlPanel.Location = new System.Drawing.Point(0, 0);
			this.pnlPanel.Name = "pnlPanel";
			this.pnlPanel.Size = new System.Drawing.Size(104, 382);
			this.pnlPanel.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbNic);
			this.groupBox1.Controls.Add(this.rbOkr¹g);
			this.groupBox1.Controls.Add(this.rbProstok¹t);
			this.groupBox1.Controls.Add(this.rbLinia);
			this.groupBox1.Location = new System.Drawing.Point(8, 112);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(88, 160);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Figury";
			// 
			// rbNic
			// 
			this.rbNic.Checked = true;
			this.rbNic.Location = new System.Drawing.Point(8, 120);
			this.rbNic.Name = "rbNic";
			this.rbNic.Size = new System.Drawing.Size(64, 24);
			this.rbNic.TabIndex = 3;
			this.rbNic.TabStop = true;
			this.rbNic.Text = "nic";
			// 
			// rbOkr¹g
			// 
			this.rbOkr¹g.Location = new System.Drawing.Point(8, 88);
			this.rbOkr¹g.Name = "rbOkr¹g";
			this.rbOkr¹g.Size = new System.Drawing.Size(64, 24);
			this.rbOkr¹g.TabIndex = 2;
			this.rbOkr¹g.Text = "okr¹g";
			// 
			// rbProstok¹t
			// 
			this.rbProstok¹t.Location = new System.Drawing.Point(8, 56);
			this.rbProstok¹t.Name = "rbProstok¹t";
			this.rbProstok¹t.Size = new System.Drawing.Size(72, 24);
			this.rbProstok¹t.TabIndex = 1;
			this.rbProstok¹t.Text = "prostok¹t";
			// 
			// rbLinia
			// 
			this.rbLinia.Location = new System.Drawing.Point(8, 24);
			this.rbLinia.Name = "rbLinia";
			this.rbLinia.Size = new System.Drawing.Size(72, 24);
			this.rbLinia.TabIndex = 0;
			this.rbLinia.Text = "linia";
			// 
			// btnKoniec
			// 
			this.btnKoniec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnKoniec.Location = new System.Drawing.Point(8, 352);
			this.btnKoniec.Name = "btnKoniec";
			this.btnKoniec.Size = new System.Drawing.Size(80, 24);
			this.btnKoniec.TabIndex = 5;
			this.btnKoniec.Text = "Koniec";
			this.btnKoniec.Click += new System.EventHandler(this.btnKoniec_Click);
			// 
			// btnZapisz
			// 
			this.btnZapisz.Location = new System.Drawing.Point(8, 48);
			this.btnZapisz.Name = "btnZapisz";
			this.btnZapisz.Size = new System.Drawing.Size(80, 24);
			this.btnZapisz.TabIndex = 1;
			this.btnZapisz.Text = "Zapisz";
			this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
			// 
			// btnOtwórz
			// 
			this.btnOtwórz.Location = new System.Drawing.Point(8, 8);
			this.btnOtwórz.Name = "btnOtwórz";
			this.btnOtwórz.Size = new System.Drawing.Size(80, 24);
			this.btnOtwórz.TabIndex = 0;
			this.btnOtwórz.Text = "Otwórz";
			this.btnOtwórz.Click += new System.EventHandler(this.btnOtwórz_Click);
			// 
			// picObrazek
			// 
			this.picObrazek.BackColor = System.Drawing.SystemColors.Window;
			this.picObrazek.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picObrazek.Location = new System.Drawing.Point(104, 0);
			this.picObrazek.Name = "picObrazek";
			this.picObrazek.Size = new System.Drawing.Size(432, 382);
			this.picObrazek.TabIndex = 1;
			this.picObrazek.TabStop = false;
			//this.picObrazek.Click += new System.EventHandler(this.picObrazek_Click);
			this.picObrazek.Paint += new System.Windows.Forms.PaintEventHandler(this.picObrazek_Paint);
			this.picObrazek.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picObrazek_MouseUp);
			this.picObrazek.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picObrazek_MouseDown);
			// 
			// ofdOtwórz
			// 
			this.ofdOtwórz.DefaultExt = "xml";
			// 
			// frmG³ówny
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(536, 382);
			this.Controls.Add(this.picObrazek);
			this.Controls.Add(this.pnlPanel);
			this.Name = "frmG³ówny";
			this.Text = "Rysunki";
			this.pnlPanel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmG³ówny());
		}

		private void btnKoniec_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void drawPicture()
		{
			Graphics g=picObrazek.CreateGraphics();
			Pen p=new Pen(Color.Black,1);
			g.Clear(Color.White);
			drawing.Draw(g,p);
		}

		private void drawMark(int x,int y)
		{
			Graphics g=picObrazek.CreateGraphics();
			Pen p=new Pen(Color.Red,1);
			g.Clear(Color.White);
			g.DrawLine(p,x-5,y-5,x+5,y+5);
			g.DrawLine(p,x+5,y-5,x-5,y+5);
            drawing.Draw(g, p);
		}

		private void picObrazek_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
            CCoordinate end = new CCoordinate(e.X,e.Y);
			//w zale¿noœci od stanu dodaj figurê
			if (rbLinia.Checked)
			{
                drawing.AddShape(new CLine(punkt, end));
			}
			if (rbProstok¹t.Checked)
			{
				//Dodaj nowy prostok¹t
                drawing.AddShape(new CRectangle(punkt, end));
			}
			if (rbOkr¹g.Checked)
			{
				//Dodaj nowy okr¹g
                drawing.AddShape(new CCircle(punkt, end));
			}
			drawPicture();
		}

		private void picObrazek_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			punkt=new CCoordinate(e.X,e.Y);
			drawMark(e.X,e.Y);
          
		}

		private void btnOtwórz_Click(object sender, System.EventArgs e)
		{
			if (ofdOtwórz.ShowDialog(this)==DialogResult.OK)
			{
				if (drawing.Load(ofdOtwórz.FileName))
					drawPicture();
				else
					MessageBox.Show("Nie mo¿na odczytaæ pliku");
			}
		}

		private void btnZapisz_Click(object sender, System.EventArgs e)
		{
			if (sfdZapisz.ShowDialog(this)==DialogResult.OK)
			{
				drawing.Save(sfdZapisz.FileName);
				drawPicture();
			}
		}

		private void picObrazek_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			drawPicture();
		}

	}
}
