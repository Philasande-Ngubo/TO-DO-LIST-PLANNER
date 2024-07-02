namespace TO_DO_LIST
{
    internal class Activity
    {
        private String name;
        private bool done;
        private DateTime day;
        public Activity(String name, bool done, DateTime day)
        {
            this.name = name;
            this.done = done;
            this.day = day;
        }
        public Activity(String line)
        {
            this.name = line.Substring(0, line.IndexOf('{'));
            line = line.Substring(line.IndexOf('{') + 1, line.Length - line.IndexOf('{') - 1);
            this.day = DateTime.Parse(line.Substring(0, line.IndexOf('{')));
            line.Substring(0, line.IndexOf('{'));
            line = line.Substring(line.IndexOf('{') + 1, 1);
            if (line == "T") { done = true; }
            else { done = false; }

        }

        public Activity(String name, DateTime day)
        {
            this.name = name;
            this.day = day;
            this.done = false;
        }

        public String Name()
        {
            return this.name;
        }

        public bool Done()
        {
            return this.done;
        }

        public DateTime Day()
        {
            return this.day;
        }

        public void Edit(String name, DateTime day)
        {
            this.name = name;
            this.day = day;

        }

        public void setDone(bool done)
        {
            this.done = done;
        }
        override
        public String ToString()
        {
            String results = this.name + "{" + this.day.ToString() + "{";
            if (done)
            {
                results += "T";
            }
            else
            {
                results += "F";

            }
            return results;
        }
    }
}
