namespace TO_DO_LIST
{
    partial class Create
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
            btnCancel = new Button();
            btnSave = new Button();
            edtName = new TextBox();
            dtPicker = new DateTimePicker();
            lblName = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(27, 27, 27);
            btnCancel.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(129, 148);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 37);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(27, 27, 27);
            btnSave.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(229, 148);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 37);
            btnSave.TabIndex = 1;
            btnSave.Text = "Add";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // edtName
            // 
            edtName.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            edtName.Location = new Point(22, 38);
            edtName.Name = "edtName";
            edtName.Size = new Size(301, 34);
            edtName.TabIndex = 2;
            // 
            // dtPicker
            // 
            dtPicker.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtPicker.Format = DateTimePickerFormat.Short;
            dtPicker.Location = new Point(22, 104);
            dtPicker.Name = "dtPicker";
            dtPicker.Size = new Size(301, 34);
            dtPicker.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(22, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(105, 21);
            lblName.TabIndex = 4;
            lblName.Text = "Description:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 80);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 5;
            label1.Text = "Deadline:";
            // 
            // Create
            // 
            AutoScaleDimensions = new SizeF(7F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(344, 202);
            Controls.Add(label1);
            Controls.Add(lblName);
            Controls.Add(dtPicker);
            Controls.Add(edtName);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Create";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private TextBox edtName;
        private DateTimePicker dtPicker;
        private Label lblName;
        private Label label1;
    }
}