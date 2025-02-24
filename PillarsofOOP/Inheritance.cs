namespace PillarsofOOP
{
    class Sponsor
    {
        protected string owner = "Rakuteen";

    }
    class Team : Sponsor
    {
        public string teamName;

        public Team(string teamName)
        {
            this.teamName = teamName;
        }

        public string printInfo()
        {
            return $"The owner of the {this.teamName} is : {base.owner} \n\n";
        }
    }
}
