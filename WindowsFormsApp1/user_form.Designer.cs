
namespace WindowsFormsApp1
{
    partial class user_form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Add_Button = new System.Windows.Forms.Button();
            this.generate_button = new System.Windows.Forms.Button();
            this.Key_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Add_Button);
            this.panel1.Controls.Add(this.generate_button);
            this.panel1.Controls.Add(this.Key_Box);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 423);
            this.panel1.TabIndex = 1;
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(106, 323);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(165, 42);
            this.Add_Button.TabIndex = 5;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            // 
            // generate_button
            // 
            this.generate_button.Location = new System.Drawing.Point(106, 210);
            this.generate_button.Name = "generate_button";
            this.generate_button.Size = new System.Drawing.Size(165, 42);
            this.generate_button.TabIndex = 4;
            this.generate_button.Text = "Generate Key";
            this.generate_button.UseVisualStyleBackColor = true;
            // 
            // Key_Box
            // 
            this.Key_Box.Location = new System.Drawing.Point(97, 178);
            this.Key_Box.Name = "Key_Box";
            this.Key_Box.Size = new System.Drawing.Size(186, 26);
            this.Key_Box.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Key";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(97, 77);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(186, 26);
            this.nameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // user_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 445);
            this.Controls.Add(this.panel1);
            this.Name = "user_form";
            this.Text = "user_form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button generate_button;
        private System.Windows.Forms.TextBox Key_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
    }
}