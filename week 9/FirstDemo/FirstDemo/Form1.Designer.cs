namespace FirstDemo
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
            this.my_button = new System.Windows.Forms.Button();
            this.my_label = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // my_button
            // 
            this.my_button.Location = new System.Drawing.Point(134, 194);
            this.my_button.Name = "my_button";
            this.my_button.Size = new System.Drawing.Size(142, 61);
            this.my_button.TabIndex = 0;
            this.my_button.Text = "button1";
            this.my_button.UseVisualStyleBackColor = true;
            this.my_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // my_label
            // 
            this.my_label.AutoSize = true;
            this.my_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.my_label.Location = new System.Drawing.Point(131, 152);
            this.my_label.Name = "my_label";
            this.my_label.Size = new System.Drawing.Size(60, 24);
            this.my_label.TabIndex = 1;
            this.my_label.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(360, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 67);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(460, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 404);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.my_label);
            this.Controls.Add(this.my_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button my_button;
        private System.Windows.Forms.Label my_label;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

