namespace GameManager
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.gamesystem = new System.Windows.Forms.TextBox();
            this.sortname = new System.Windows.Forms.Button();
            this.Rating = new System.Windows.Forms.Label();
            this.Published = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.gamedate = new System.Windows.Forms.TextBox();
            this.gamerate = new System.Windows.Forms.TextBox();
            this.gamename = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sortsystem = new System.Windows.Forms.Button();
            this.sortyear = new System.Windows.Forms.Button();
            this.sortrating = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.sortrating);
            this.splitContainer1.Panel1.Controls.Add(this.sortyear);
            this.splitContainer1.Panel1.Controls.Add(this.sortsystem);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.gamesystem);
            this.splitContainer1.Panel1.Controls.Add(this.sortname);
            this.splitContainer1.Panel1.Controls.Add(this.Rating);
            this.splitContainer1.Panel1.Controls.Add(this.Published);
            this.splitContainer1.Panel1.Controls.Add(this.name);
            this.splitContainer1.Panel1.Controls.Add(this.gamedate);
            this.splitContainer1.Panel1.Controls.Add(this.gamerate);
            this.splitContainer1.Panel1.Controls.Add(this.gamename);
            this.splitContainer1.Panel1.Controls.Add(this.Add);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(667, 464);
            this.splitContainer1.SplitterDistance = 222;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "System";
            // 
            // gamesystem
            // 
            this.gamesystem.Location = new System.Drawing.Point(12, 296);
            this.gamesystem.Name = "gamesystem";
            this.gamesystem.Size = new System.Drawing.Size(176, 20);
            this.gamesystem.TabIndex = 8;
            // 
            // sortname
            // 
            this.sortname.Location = new System.Drawing.Point(12, 65);
            this.sortname.Name = "sortname";
            this.sortname.Size = new System.Drawing.Size(79, 24);
            this.sortname.TabIndex = 7;
            this.sortname.Text = "Sort by Name";
            this.sortname.UseVisualStyleBackColor = true;
            this.sortname.Click += new System.EventHandler(this.sortname_Click);
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.Location = new System.Drawing.Point(12, 379);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(38, 13);
            this.Rating.TabIndex = 6;
            this.Rating.Text = "Rating";
            // 
            // Published
            // 
            this.Published.AutoSize = true;
            this.Published.Location = new System.Drawing.Point(12, 331);
            this.Published.Name = "Published";
            this.Published.Size = new System.Drawing.Size(66, 13);
            this.Published.TabIndex = 5;
            this.Published.Text = "Publish Year";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(12, 230);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 4;
            this.name.Text = "Name";
            // 
            // gamedate
            // 
            this.gamedate.Location = new System.Drawing.Point(12, 347);
            this.gamedate.Name = "gamedate";
            this.gamedate.Size = new System.Drawing.Size(176, 20);
            this.gamedate.TabIndex = 3;
            // 
            // gamerate
            // 
            this.gamerate.Location = new System.Drawing.Point(12, 395);
            this.gamerate.Name = "gamerate";
            this.gamerate.Size = new System.Drawing.Size(176, 20);
            this.gamerate.TabIndex = 2;
            // 
            // gamename
            // 
            this.gamename.Location = new System.Drawing.Point(12, 246);
            this.gamename.Name = "gamename";
            this.gamename.Size = new System.Drawing.Size(176, 20);
            this.gamename.TabIndex = 1;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(12, 421);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(191, 31);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(414, 440);
            this.dataGridView1.TabIndex = 0;
            // 
            // sortsystem
            // 
            this.sortsystem.Location = new System.Drawing.Point(12, 95);
            this.sortsystem.Name = "sortsystem";
            this.sortsystem.Size = new System.Drawing.Size(97, 23);
            this.sortsystem.TabIndex = 10;
            this.sortsystem.Text = " Sort by System";
            this.sortsystem.UseVisualStyleBackColor = true;
            this.sortsystem.Click += new System.EventHandler(this.sortsystem_Click);
            // 
            // sortyear
            // 
            this.sortyear.Location = new System.Drawing.Point(12, 124);
            this.sortyear.Name = "sortyear";
            this.sortyear.Size = new System.Drawing.Size(75, 23);
            this.sortyear.TabIndex = 11;
            this.sortyear.Text = "Sort by Year";
            this.sortyear.UseVisualStyleBackColor = true;
            this.sortyear.Click += new System.EventHandler(this.sortyear_Click);
            // 
            // sortrating
            // 
            this.sortrating.Location = new System.Drawing.Point(12, 153);
            this.sortrating.Name = "sortrating";
            this.sortrating.Size = new System.Drawing.Size(97, 23);
            this.sortrating.TabIndex = 12;
            this.sortrating.Text = "Sort by Rating";
            this.sortrating.UseVisualStyleBackColor = true;
            this.sortrating.Click += new System.EventHandler(this.sortrating_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 464);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.Label Published;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox gamedate;
        private System.Windows.Forms.TextBox gamerate;
        private System.Windows.Forms.TextBox gamename;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button sortname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gamesystem;
        private System.Windows.Forms.Button sortrating;
        private System.Windows.Forms.Button sortyear;
        private System.Windows.Forms.Button sortsystem;
    }
}

