using System.Collections;

namespace TO_DO_LIST
{
    public partial class UI : Form
    {
        private ArrayList activities;
        public UI()
        {
            InitializeComponent();
            activities = new ArrayList();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {

            using (StreamWriter writer = new StreamWriter("Activities.txt"))
            {
                foreach (ActiPanel actiPanel in activities) { writer.WriteLine(actiPanel.Activity().ToString()); }
            }
            this.Close();
        }

        private void fillActivities()
        {
            paneActivities.Controls.Clear();
            int top = 10;
            foreach (ActiPanel actiPanel in activities)
            {
                paneActivities.Controls.Add(actiPanel);
                actiPanel.Location = new Point(0, top);
                actiPanel.Edited();
                top += 70;
            }
        }

        internal void Add(ActiPanel actiPanel)
        {
            activities.Add(actiPanel);
            fillActivities();
        }

        internal void Remove(ActiPanel actiPanel)
        {
            activities.Remove(actiPanel);
            fillActivities();
        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            new Create(this);
        }

        private void paneActivities_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void UI_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void UI_Load(object sender, EventArgs e)
        {

            try
            {
                using (StreamReader sr = File.OpenText("Activities.txt"))
                {
                    string line = "";
                    while ((line = sr.ReadLine()) != null)
                    {
                        activities.Add(new ActiPanel(new Activity(line), this));
                    }
                }
                fillActivities();
            }
            catch (Exception ex) { }


        }
    }
}
