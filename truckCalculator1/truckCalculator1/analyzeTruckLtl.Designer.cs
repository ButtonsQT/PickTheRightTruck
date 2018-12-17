namespace truckCalculator1
{
    partial class GlorifiedCalculator
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
            this.stackable = new System.Windows.Forms.CheckBox();
            this.weightQuestions = new System.Windows.Forms.Label();
            this.dimentionsQuestions = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.length = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.units = new System.Windows.Forms.Label();
            this.unitTextbox = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stackable
            // 
            this.stackable.AutoSize = true;
            this.stackable.Location = new System.Drawing.Point(12, 166);
            this.stackable.Name = "stackable";
            this.stackable.Size = new System.Drawing.Size(134, 17);
            this.stackable.TabIndex = 0;
            this.stackable.Text = "Will these be stacked?";
            this.stackable.UseVisualStyleBackColor = true;
            this.stackable.CheckedChanged += new System.EventHandler(this.stackable_CheckedChanged);
            // 
            // weightQuestions
            // 
            this.weightQuestions.AutoSize = true;
            this.weightQuestions.Location = new System.Drawing.Point(6, 83);
            this.weightQuestions.Name = "weightQuestions";
            this.weightQuestions.Size = new System.Drawing.Size(127, 13);
            this.weightQuestions.TabIndex = 1;
            this.weightQuestions.Text = "how much does it weigh?";
            // 
            // dimentionsQuestions
            // 
            this.dimentionsQuestions.AutoSize = true;
            this.dimentionsQuestions.Location = new System.Drawing.Point(9, 128);
            this.dimentionsQuestions.Name = "dimentionsQuestions";
            this.dimentionsQuestions.Size = new System.Drawing.Size(130, 13);
            this.dimentionsQuestions.TabIndex = 2;
            this.dimentionsQuestions.Text = "What are the dimensions?";
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(176, 128);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.lengthTextBox.TabIndex = 3;
            this.lengthTextBox.TextChanged += new System.EventHandler(this.lengthTextBox_TextChanged);
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(293, 127);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 20);
            this.widthTextBox.TabIndex = 4;
            this.widthTextBox.TextChanged += new System.EventHandler(this.widthTextBox_TextChanged);
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(400, 127);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 5;
            this.heightTextBox.TextChanged += new System.EventHandler(this.heightTextBox_TextChanged);
            // 
            // length
            // 
            this.length.AutoSize = true;
            this.length.Location = new System.Drawing.Point(173, 112);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(40, 13);
            this.length.TabIndex = 6;
            this.length.Text = "Length";
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.Location = new System.Drawing.Point(298, 108);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(35, 13);
            this.width.TabIndex = 7;
            this.width.Text = "Width";
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Location = new System.Drawing.Point(402, 111);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(38, 13);
            this.height.TabIndex = 8;
            this.height.Text = "Height";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(160, 83);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 9;
            this.weightTextBox.TextChanged += new System.EventHandler(this.weightTextBox_TextChanged);
            // 
            // units
            // 
            this.units.AutoSize = true;
            this.units.Location = new System.Drawing.Point(9, 42);
            this.units.Name = "units";
            this.units.Size = new System.Drawing.Size(88, 13);
            this.units.TabIndex = 16;
            this.units.Text = "How many units?";
            // 
            // unitTextbox
            // 
            this.unitTextbox.Location = new System.Drawing.Point(160, 42);
            this.unitTextbox.Name = "unitTextbox";
            this.unitTextbox.Size = new System.Drawing.Size(100, 20);
            this.unitTextbox.TabIndex = 17;
            this.unitTextbox.TextChanged += new System.EventHandler(this.unitTextbox_TextChanged);
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button.FlatAppearance.BorderSize = 3;
            this.button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button.Location = new System.Drawing.Point(96, 189);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(366, 23);
            this.button.TabIndex = 18;
            this.button.Text = "Press this when you have Entered all of the information.";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // GlorifiedCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 289);
            this.Controls.Add(this.button);
            this.Controls.Add(this.unitTextbox);
            this.Controls.Add(this.units);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.height);
            this.Controls.Add(this.width);
            this.Controls.Add(this.length);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.dimentionsQuestions);
            this.Controls.Add(this.weightQuestions);
            this.Controls.Add(this.stackable);
            this.Name = "GlorifiedCalculator";
            this.Text = "GlorifiedCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox stackable;
        private System.Windows.Forms.Label weightQuestions;
        private System.Windows.Forms.Label dimentionsQuestions;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label length;
        private System.Windows.Forms.Label width;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label units;
        private System.Windows.Forms.TextBox unitTextbox;
        private System.Windows.Forms.Button button;
    }
}

