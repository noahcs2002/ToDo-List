
namespace TDL
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
            this.label1 = new System.Windows.Forms.Label();
            this.itemToBeAdded = new System.Windows.Forms.TextBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.author = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "To Do:";
            // 
            // itemToBeAdded
            // 
            this.itemToBeAdded.Location = new System.Drawing.Point(18, 62);
            this.itemToBeAdded.Margin = new System.Windows.Forms.Padding(1);
            this.itemToBeAdded.Name = "itemToBeAdded";
            this.itemToBeAdded.Size = new System.Drawing.Size(137, 20);
            this.itemToBeAdded.TabIndex = 1;
            this.itemToBeAdded.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterPressed);
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(18, 93);
            this.addItemButton.Margin = new System.Windows.Forms.Padding(1);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(137, 40);
            this.addItemButton.TabIndex = 2;
            this.addItemButton.Text = "Add!";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addButtonClicked);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(18, 147);
            this.clearButton.Margin = new System.Windows.Forms.Padding(1);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(137, 40);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear!";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clearButtonClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox15);
            this.panel1.Controls.Add(this.checkBox14);
            this.panel1.Controls.Add(this.checkBox13);
            this.panel1.Controls.Add(this.checkBox12);
            this.panel1.Controls.Add(this.checkBox11);
            this.panel1.Controls.Add(this.checkBox10);
            this.panel1.Controls.Add(this.checkBox9);
            this.panel1.Controls.Add(this.checkBox8);
            this.panel1.Controls.Add(this.checkBox7);
            this.panel1.Controls.Add(this.checkBox6);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Location = new System.Drawing.Point(186, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 382);
            this.panel1.TabIndex = 4;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(4, 356);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(15, 14);
            this.checkBox15.TabIndex = 14;
            this.checkBox15.UseVisualStyleBackColor = true;
            this.checkBox15.Visible = false;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(4, 331);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(15, 14);
            this.checkBox14.TabIndex = 13;
            this.checkBox14.UseVisualStyleBackColor = true;
            this.checkBox14.Visible = false;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(3, 306);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(15, 14);
            this.checkBox13.TabIndex = 12;
            this.checkBox13.UseVisualStyleBackColor = true;
            this.checkBox13.Visible = false;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(4, 281);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(15, 14);
            this.checkBox12.TabIndex = 11;
            this.checkBox12.UseVisualStyleBackColor = true;
            this.checkBox12.Visible = false;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(4, 256);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(15, 14);
            this.checkBox11.TabIndex = 10;
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.Visible = false;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(4, 231);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(15, 14);
            this.checkBox10.TabIndex = 9;
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.Visible = false;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(3, 206);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(15, 14);
            this.checkBox9.TabIndex = 8;
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.Visible = false;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(4, 181);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(15, 14);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.Visible = false;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(4, 156);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(15, 14);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.Visible = false;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(4, 131);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(15, 14);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.Visible = false;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(4, 106);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.Visible = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(4, 79);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.Visible = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(3, 54);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(4, 29);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Location = new System.Drawing.Point(15, 429);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(94, 15);
            this.author.TabIndex = 5;
            this.author.Text = "By Noah Sternberg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(472, 456);
            this.Controls.Add(this.author);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.itemToBeAdded);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "To Do List";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemToBeAdded;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label author;
    }
}

