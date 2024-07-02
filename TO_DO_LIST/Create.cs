namespace TO_DO_LIST
{
    public partial class Create : Form
    {
        UI ui;
        ActiPanel actiPanel;
        public Create(Object o)
        {
            InitializeComponent();
            this.Show();
            if (o is UI)
            {
                this.ui = (UI)o;
                btnSave.Text = "Add";
            }
            else
            {
                if (o is ActiPanel)
                {
                    this.actiPanel = (ActiPanel)o;
                    btnSave.Text = "Save";
                    edtName.Text = actiPanel.Activity().Name();
                    dtPicker.Value = actiPanel.Activity().Day();
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (edtName.Text.Length > 1)
            {
                if (btnSave.Text == "Add")
                {
                    ui.Add(new ActiPanel(new Activity(edtName.Text.Trim(), dtPicker.Value), ui));
                }
                else
                {
                    Activity temp = actiPanel.Activity();
                    temp.Edit(edtName.Text, dtPicker.Value);
                    actiPanel.Edited();
                }
                this.Close();
            }
            else { edtName.Select(); }
        }
    }
}
