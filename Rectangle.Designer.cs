namespace rameez_shapes
{
    partial class Rectangle
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
            this.back_button = new System.Windows.Forms.Button();
            this.Linput = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.result_label = new System.Windows.Forms.Label();
            this.calculate_label = new System.Windows.Forms.Label();
            this.parameter_button = new System.Windows.Forms.Button();
            this.area_button = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label = new System.Windows.Forms.Label();
            this.length_label = new System.Windows.Forms.Label();
            this.Winput = new System.Windows.Forms.TextBox();
            this.width_label = new System.Windows.Forms.Label();
            this.move_circle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.LightYellow;
            this.back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back_button.Font = new System.Drawing.Font("Forte", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.back_button.Location = new System.Drawing.Point(1, 363);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(103, 43);
            this.back_button.TabIndex = 20;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Linput
            // 
            this.Linput.Location = new System.Drawing.Point(133, 127);
            this.Linput.Name = "Linput";
            this.Linput.Size = new System.Drawing.Size(94, 27);
            this.Linput.TabIndex = 19;
            this.Linput.TextChanged += new System.EventHandler(this.Linput_TextChanged);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Forte", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.result.Location = new System.Drawing.Point(357, 314);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(196, 25);
            this.result.TabIndex = 18;
            this.result.Text = "Result diplay here";
            this.result.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Font = new System.Drawing.Font("Forte", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result_label.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.result_label.Location = new System.Drawing.Point(394, 258);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(89, 30);
            this.result_label.TabIndex = 17;
            this.result_label.Text = "Result";
            this.result_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // calculate_label
            // 
            this.calculate_label.AutoSize = true;
            this.calculate_label.Font = new System.Drawing.Font("Forte", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculate_label.Location = new System.Drawing.Point(634, 95);
            this.calculate_label.Name = "calculate_label";
            this.calculate_label.Size = new System.Drawing.Size(121, 26);
            this.calculate_label.TabIndex = 16;
            this.calculate_label.Text = "Calculate ";
            this.calculate_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // parameter_button
            // 
            this.parameter_button.BackColor = System.Drawing.Color.LightYellow;
            this.parameter_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parameter_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parameter_button.Font = new System.Drawing.Font("Forte", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.parameter_button.Location = new System.Drawing.Point(713, 134);
            this.parameter_button.Name = "parameter_button";
            this.parameter_button.Size = new System.Drawing.Size(103, 43);
            this.parameter_button.TabIndex = 15;
            this.parameter_button.Text = "Parameter";
            this.parameter_button.UseVisualStyleBackColor = false;
            this.parameter_button.Click += new System.EventHandler(this.parameter_button_Click);
            // 
            // area_button
            // 
            this.area_button.BackColor = System.Drawing.Color.LightYellow;
            this.area_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.area_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.area_button.Font = new System.Drawing.Font("Forte", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.area_button.Location = new System.Drawing.Point(590, 134);
            this.area_button.Name = "area_button";
            this.area_button.Size = new System.Drawing.Size(103, 43);
            this.area_button.TabIndex = 14;
            this.area_button.Text = "Area";
            this.area_button.UseVisualStyleBackColor = false;
            this.area_button.Click += new System.EventHandler(this.area_button_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(26, 219);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(680, 26);
            this.hScrollBar1.TabIndex = 13;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Forte", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(345, 49);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(207, 26);
            this.label.TabIndex = 12;
            this.label.Text = "Area of Rectangle  ";
            this.label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // length_label
            // 
            this.length_label.AutoSize = true;
            this.length_label.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.length_label.Location = new System.Drawing.Point(41, 127);
            this.length_label.Name = "length_label";
            this.length_label.Size = new System.Drawing.Size(76, 22);
            this.length_label.TabIndex = 11;
            this.length_label.Text = "Length :";
            // 
            // Winput
            // 
            this.Winput.Location = new System.Drawing.Point(133, 173);
            this.Winput.Name = "Winput";
            this.Winput.Size = new System.Drawing.Size(94, 27);
            this.Winput.TabIndex = 22;
            this.Winput.TextChanged += new System.EventHandler(this.Winput_TextChanged);
            // 
            // width_label
            // 
            this.width_label.AutoSize = true;
            this.width_label.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.width_label.Location = new System.Drawing.Point(41, 173);
            this.width_label.Name = "width_label";
            this.width_label.Size = new System.Drawing.Size(75, 22);
            this.width_label.TabIndex = 21;
            this.width_label.Text = "Width : ";
            // 
            // move_circle
            // 
            this.move_circle.BackColor = System.Drawing.Color.LightYellow;
            this.move_circle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.move_circle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.move_circle.Font = new System.Drawing.Font("Forte", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.move_circle.Location = new System.Drawing.Point(754, 363);
            this.move_circle.Name = "move_circle";
            this.move_circle.Size = new System.Drawing.Size(103, 43);
            this.move_circle.TabIndex = 23;
            this.move_circle.Text = "Circle";
            this.move_circle.UseVisualStyleBackColor = false;
            this.move_circle.Click += new System.EventHandler(this.move_circle_Click);
            // 
            // Rectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.move_circle);
            this.Controls.Add(this.Winput);
            this.Controls.Add(this.width_label);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.Linput);
            this.Controls.Add(this.result);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.calculate_label);
            this.Controls.Add(this.parameter_button);
            this.Controls.Add(this.area_button);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.length_label);
            this.Name = "Rectangle";
            this.Text = "Rectangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button back_button;
        private TextBox Linput;
        private Label result;
        private Label result_label;
        private Label calculate_label;
        private Button parameter_button;
        private Button area_button;
        private HScrollBar hScrollBar1;
        private Label label;
        private Label length_label;
        private TextBox Winput;
        private Label width_label;
        private Button move_circle;
    }
}