namespace PillarsofOOP
{
    // Base(Parent) Sponsor Class
    class Sponsor
    {
        // Protected field owner so it can only be accessed in current class and its child classes and assigning an default value to it
        protected string owner = "Rakuteen";
    }

    // Team class as child class of Sponsor
    class Team : Sponsor
    {
        // Private field teamName so it can only be accessed in current class
        private string teamName;
        // Public parameterized constructor to initalize the objects
        public Team(string teamName)
        {
            this.teamName = teamName;
        }
        // Public method for calling it in different class
        // Working : Return type is string as it returns statement as string
        public string printInfo()
        {
            return $"The owner of the {this.teamName} is : {base.owner} \n\n";
        }
    }
}
