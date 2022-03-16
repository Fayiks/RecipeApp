
namespace WindowsFormsApp1
{
    partial class FoodApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodApp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vegetableControl11 = new WindowsFormsApp1.VegetableControl1();
            this.beverageControl11 = new WindowsFormsApp1.BeverageControl1();
            this.pastriesControl11 = new WindowsFormsApp1.PastriesControl1();
            this.homeControl11 = new WindowsFormsApp1.HomeControl1();
            this.suggestionControl11 = new WindowsFormsApp1.SuggestionControl1();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 528);
            this.panel1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Silver;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(16, 373);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 35);
            this.button5.TabIndex = 6;
            this.button5.Text = "Sugesstions";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(16, 311);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 35);
            this.button4.TabIndex = 5;
            this.button4.Text = "Vegetables";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(16, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "Beverages";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(16, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Pastries";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.SidePanel.Location = new System.Drawing.Point(3, 120);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(13, 35);
            this.SidePanel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(16, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Home";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.IMG_20210316_074231;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // vegetableControl11
            // 
            this.vegetableControl11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vegetableControl11.Location = new System.Drawing.Point(114, 0);
            this.vegetableControl11.Name = "vegetableControl11";
            this.vegetableControl11.Size = new System.Drawing.Size(694, 528);
            this.vegetableControl11.TabIndex = 4;
            // 
            // beverageControl11
            // 
            this.beverageControl11.BackColor = System.Drawing.Color.LightGray;
            this.beverageControl11.Location = new System.Drawing.Point(114, 0);
            this.beverageControl11.Name = "beverageControl11";
            this.beverageControl11.Size = new System.Drawing.Size(694, 528);
            this.beverageControl11.TabIndex = 3;
            // 
            // pastriesControl11
            // 
            this.pastriesControl11.BackColor = System.Drawing.Color.LightGray;
            this.pastriesControl11.Location = new System.Drawing.Point(114, 0);
            this.pastriesControl11.Name = "pastriesControl11";
            this.pastriesControl11.Size = new System.Drawing.Size(694, 528);
            this.pastriesControl11.TabIndex = 2;
            this.pastriesControl11.Load += new System.EventHandler(this.pastriesControl11_Load);
            // 
            // homeControl11
            // 
            this.homeControl11.BackColor = System.Drawing.Color.LightGray;
            this.homeControl11.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.homeControl11.Location = new System.Drawing.Point(114, 0);
            this.homeControl11.Name = "homeControl11";
            this.homeControl11.Size = new System.Drawing.Size(694, 528);
            this.homeControl11.TabIndex = 1;
            // 
            // suggestionControl11
            // 
            this.suggestionControl11.Location = new System.Drawing.Point(114, 0);
            this.suggestionControl11.Name = "suggestionControl11";
            this.suggestionControl11.Size = new System.Drawing.Size(694, 528);
            this.suggestionControl11.TabIndex = 5;
            // 
            // FoodApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 528);
            this.Controls.Add(this.suggestionControl11);
            this.Controls.Add(this.vegetableControl11);
            this.Controls.Add(this.beverageControl11);
            this.Controls.Add(this.pastriesControl11);
            this.Controls.Add(this.homeControl11);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FoodApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodApp";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button button1;
        private HomeControl1 homeControl11;
        private PastriesControl1 pastriesControl11;
        private BeverageControl1 beverageControl11;
        private VegetableControl1 vegetableControl11;
        private SuggestionControl1 suggestionControl11;
    }
}