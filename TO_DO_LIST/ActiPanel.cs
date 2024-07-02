namespace TO_DO_LIST
{
    internal class ActiPanel : Panel
    {
        private Activity activity;
        private CheckBox checkBox = new CheckBox();
        private Label lblTime = new Label();
        private Label lblEdit = new Label();
        private Label lblDelete = new Label();
        UI ui;
        public ActiPanel(Activity activity, UI ui)
        {
            this.ui = ui;
            base.Size = new System.Drawing.Size(360, 60);
            base.BackColor = Color.FromArgb(69, 69, 69);
            this.activity = activity;

            lblTime.Text = "12:00\n21.12.2023";
            lblTime.ForeColor = Color.FromArgb(200, 200, 200);
            lblTime.Location = new Point(240, 20);
            lblTime.Font = new Font("Arial", 7);
            lblTime.Size = new Size(70, 30);


            checkBox.Text = " Test";
            checkBox.ForeColor = Color.White;
            checkBox.Location = new Point(30, 20);
            checkBox.Font = new Font("Arial", 11);
            checkBox.Size = new Size(210, 30);
            checkBox.CheckedChanged += changedCheck;

            lblEdit.Text = "✎";
            lblEdit.ForeColor = Color.FromArgb(200, 200, 200);
            lblEdit.Font = new Font("Arial", 14);
            lblEdit.Location = new Point(320, 3);
            lblEdit.Click += lblEdit_Click;

            lblDelete.Text = "✖";
            lblDelete.ForeColor = Color.FromArgb(200, 200, 200);
            lblDelete.Font = new Font("Arial", 12);
            lblDelete.Location = new Point(322, 30);
            lblDelete.Click += lblDelete_Click;

            base.Controls.Add(checkBox);
            base.Controls.Add(lblTime);
            base.Controls.Add(lblEdit);
            base.Controls.Add(lblDelete);
            Edited();
        }

        public void Edited()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.Active = true;
            toolTip.AutoPopDelay = 4000;
            toolTip.InitialDelay = 600;
            toolTip.IsBalloon = true;
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            String chkBoxText = activity.Name();
            if (chkBoxText.Length > 17) { chkBoxText = activity.Name().Substring(0, 17); }
            checkBox.Text = " " + chkBoxText;
            lblTime.Text = Zero(activity.Day().Hour.ToString()) + ":" + Zero(activity.Day().Minute.ToString()) + "\n" + Zero(activity.Day().Day.ToString()) + "." +
                           Zero(activity.Day().Month.ToString()) + "." + activity.Day().Year.ToString();
            toolTip.SetToolTip(checkBox, activity.Name());
        }

        private String Zero(String s)
        {
            if (s.Length == 1) { return "0" + s; }
            return s;
        }

        private void lblDelete_Click(object? sender, EventArgs e)
        {
            ui.Remove(this);

        }

        private void lblEdit_Click(object? sender, EventArgs e)
        {
            new Create(this);
        }

        private void changedCheck(object? sender, EventArgs e)
        {
            this.activity.setDone(checkBox.Checked);
        }

        public Activity Activity()
        {
            return activity;
        }

    }
}
