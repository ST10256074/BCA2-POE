namespace RecipeGUI
{
    partial class RecipeEntry
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rISteps = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbIName = new System.Windows.Forms.TextBox();
            this.tbIQuan = new System.Windows.Forms.TextBox();
            this.tbICal = new System.Windows.Forms.TextBox();
            this.tbIUnit = new System.Windows.Forms.TextBox();
            this.cbIGroup = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recipe Entry Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 483);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Steps";
            // 
            // rISteps
            // 
            this.rISteps.Location = new System.Drawing.Point(162, 483);
            this.rISteps.Name = "rISteps";
            this.rISteps.Size = new System.Drawing.Size(302, 96);
            this.rISteps.TabIndex = 3;
            this.rISteps.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ingredients";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(162, 393);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(165, 84);
            this.listBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 217);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Ingredient";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(162, 105);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(165, 22);
            this.tbName.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 586);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Confirm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(43, 586);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbIName
            // 
            this.tbIName.Location = new System.Drawing.Point(195, 158);
            this.tbIName.Name = "tbIName";
            this.tbIName.Size = new System.Drawing.Size(100, 22);
            this.tbIName.TabIndex = 10;
            // 
            // tbIQuan
            // 
            this.tbIQuan.Location = new System.Drawing.Point(195, 205);
            this.tbIQuan.Name = "tbIQuan";
            this.tbIQuan.Size = new System.Drawing.Size(100, 22);
            this.tbIQuan.TabIndex = 11;
            // 
            // tbICal
            // 
            this.tbICal.Location = new System.Drawing.Point(195, 256);
            this.tbICal.Name = "tbICal";
            this.tbICal.Size = new System.Drawing.Size(100, 22);
            this.tbICal.TabIndex = 12;
            // 
            // tbIUnit
            // 
            this.tbIUnit.Location = new System.Drawing.Point(195, 302);
            this.tbIUnit.Name = "tbIUnit";
            this.tbIUnit.Size = new System.Drawing.Size(100, 22);
            this.tbIUnit.TabIndex = 13;
            // 
            // cbIGroup
            // 
            this.cbIGroup.FormattingEnabled = true;
            this.cbIGroup.Items.AddRange(new object[] {
            "Dairy",
            "Protein",
            "Fruit",
            "Vegetable",
            "Grain",
            "Sweets",
            "Fats",
            "Other"});
            this.cbIGroup.Location = new System.Drawing.Point(195, 351);
            this.cbIGroup.Name = "cbIGroup";
            this.cbIGroup.Size = new System.Drawing.Size(121, 24);
            this.cbIGroup.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Calories";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Unit of Measurement";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Food Group";
            // 
            // RecipeEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 623);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbIGroup);
            this.Controls.Add(this.tbIUnit);
            this.Controls.Add(this.tbICal);
            this.Controls.Add(this.tbIQuan);
            this.Controls.Add(this.tbIName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rISteps);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RecipeEntry";
            this.Text = "RecipeEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rISteps;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbIName;
        private System.Windows.Forms.TextBox tbIQuan;
        private System.Windows.Forms.TextBox tbICal;
        private System.Windows.Forms.TextBox tbIUnit;
        private System.Windows.Forms.ComboBox cbIGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}