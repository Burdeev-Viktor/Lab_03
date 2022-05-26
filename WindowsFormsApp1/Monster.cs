namespace WindowsFormsApp1
{
    public class Monster
    {
        private int id;
        private string name;
        private string genus;
        private string drop;
        private string danger;

        public Monster(object[] array)
        {
            id = (int)array[0];
            name = (string)array[1];
            genus = (string)array[2];
            drop = (string)array[3];
            danger = (string)array[4];
        }
        public Monster(string name,string genus,string drop,string danger)
        {
            this.name = name;
            this.genus = genus;
            this.drop = drop;
            this.danger = danger;
        }
        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Genus
        {
            get => genus;
            set => genus = value;
        }

        public string Drop
        {
            get => drop;
            set => drop = value;
        }

        public string Danger
        {
            get => danger;
            set => danger = value;
        }
    }
}