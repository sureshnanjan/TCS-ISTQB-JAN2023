namespace PetStoreDesktopApplication
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reptileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "logo.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fishToolStripMenuItem,
            this.toolStripMenuItem1,
            this.reptileToolStripMenuItem,
            this.catToolStripMenuItem,
            this.birdToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fishToolStripMenuItem
            // 
            this.fishToolStripMenuItem.AccessibleDescription = "This is for Choosing Fish";
            this.fishToolStripMenuItem.AccessibleName = "FishMenu";
            this.fishToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.fishToolStripMenuItem.Name = "fishToolStripMenuItem";
            this.fishToolStripMenuItem.Size = new System.Drawing.Size(59, 29);
            this.fishToolStripMenuItem.Text = "Fish";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(63, 29);
            this.toolStripMenuItem1.Text = "Dog";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // reptileToolStripMenuItem
            // 
            this.reptileToolStripMenuItem.Name = "reptileToolStripMenuItem";
            this.reptileToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.reptileToolStripMenuItem.Text = "Reptile";
            // 
            // catToolStripMenuItem
            // 
            this.catToolStripMenuItem.Name = "catToolStripMenuItem";
            this.catToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.catToolStripMenuItem.Text = "Cat";
            // 
            // birdToolStripMenuItem
            // 
            this.birdToolStripMenuItem.Name = "birdToolStripMenuItem";
            this.birdToolStripMenuItem.Size = new System.Drawing.Size(59, 29);
            this.birdToolStripMenuItem.Text = "Bird";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.AccessibleDescription = "Enter text to search item in petstore";
            this.textBox1.AccessibleName = "searchiteminput";
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBox1.Location = new System.Drawing.Point(419, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Type Name to Search";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "JPetStore";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reptileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birdToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

