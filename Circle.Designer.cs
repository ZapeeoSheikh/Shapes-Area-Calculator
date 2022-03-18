namespace rameez_shapes
{
    partial class Circle
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
            this.radius_label = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.area_button = new System.Windows.Forms.Button();
            this.parameter_button = new System.Windows.Forms.Button();
            this.calculate_label = new System.Windows.Forms.Label();
            this.result_label = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.back_button = new System.Windows.Forms.Button();
            this.move_rectangle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radius_label
            // 
            this.radius_label.AutoSize = true;
            this.radius_label.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radius_label.Location = new System.Drawing.Point(67, 143);
            this.radius_label.Name = "radius_label";
            this.radius_label.Size = new System.Drawing.Size(86, 22);
            this.radius_label.TabIndex = 0;
            this.radius_label.Text = "Radius : ";
            this.radius_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Forte", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(420, 49);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(159, 26);
            this.label.TabIndex = 2;
            this.label.Text = "Area of Circle ";
            this.label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label.Click += new System.EventHandler(this.label2_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(52, 219);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(680, 26);
            this.hScrollBar1.TabIndex = 3;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // area_button
            // 
            this.area_button.BackColor = System.Drawing.Color.LightYellow;
            this.area_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.area_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.area_button.Font = new System.Drawing.Font("Forte", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.area_button.Location = new System.Drawing.Point(616, 134);
            this.area_button.Name = "area_button";
            this.area_button.Size = new System.Drawing.Size(103, 43);
            this.area_button.TabIndex = 4;
            this.area_button.Text = "Area";
            this.area_button.UseVisualStyleBackColor = false;
            this.area_button.Click += new System.EventHandler(this.area_button_Click);
            // 
            // parameter_button
            // 
            this.parameter_button.BackColor = System.Drawing.Color.LightYellow;
            this.parameter_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parameter_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.parameter_button.Font = new System.Drawing.Font("Forte", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.parameter_button.Location = new System.Drawing.Point(739, 134);
            this.parameter_button.Name = "parameter_button";
            this.parameter_button.Size = new System.Drawing.Size(103, 43);
            this.parameter_button.TabIndex = 5;
            this.parameter_button.Text = "Parameter";
            this.parameter_button.UseVisualStyleBackColor = false;
            this.parameter_button.Click += new System.EventHandler(this.parameter_button_Click);
            // 
            // calculate_label
            // 
            this.calculate_label.AutoSize = true;
            this.calculate_label.Font = new System.Drawing.Font("Forte", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculate_label.Location = new System.Drawing.Point(660, 95);
            this.calculate_label.Name = "calculate_label";
            this.calculate_label.Size = new System.Drawing.Size(121, 26);
            this.calculate_label.TabIndex = 6;
            this.calculate_label.Text = "Calculate ";
            this.calculate_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.calculate_label.Click += new System.EventHandler(this.calculate_label_Click);
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Font = new System.Drawing.Font("Forte", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result_label.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.result_label.Location = new System.Drawing.Point(420, 258);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(89, 30);
            this.result_label.TabIndex = 7;
            this.result_label.Text = "Result";
            this.result_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Forte", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.result.Location = new System.Drawing.Point(383, 314);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(196, 25);
            this.result.TabIndex = 8;
            this.result.Text = "Result diplay here";
            this.result.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(159, 143);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(94, 27);
            this.input.TabIndex = 9;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.LightYellow;
            this.back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back_button.Font = new System.Drawing.Font("Forte", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.back_button.Location = new System.Drawing.Point(27, 363);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(103, 43);
            this.back_button.TabIndex = 10;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // move_rectangle
            // 
            this.move_rectangle.BackColor = System.Drawing.Color.LightYellow;
            this.move_rectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.move_rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.move_rectangle.Font = new System.Drawing.Font("Forte", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.move_rectangle.Location = new System.Drawing.Point(803, 363);
            this.move_rectangle.Name = "move_rectangle";
            this.move_rectangle.Size = new System.Drawing.Size(103, 43);
            this.move_rectangle.TabIndex = 11;
            this.move_rectangle.Text = "Rectangle";
            this.move_rectangle.UseVisualStyleBackColor = false;
            this.move_rectangle.Click += new System.EventHandler(this.move_rectangle_Click);
            // 
            // Circle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 450);
            this.Controls.Add(this.move_rectangle);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.input);
            this.Controls.Add(this.result);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.calculate_label);
            this.Controls.Add(this.parameter_button);
            this.Controls.Add(this.area_button);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.radius_label);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.Name = "Circle";
            this.Text = "Circle";
            this.Load += new System.EventHandler(this.Circle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label radius_label;
        private Label label;
        private HScrollBar hScrollBar1;
        private Button area_button;
        private Button parameter_button;
        private Label calculate_label;
        private Label result_label;
        private Label result;
        private TextBox input;
        private Button back_button;
        private Button move_rectangle;
    }
}