namespace Models
{
    public class Episode : Media
    {
        public string Description { get; set; }

        public Episode(string pName) : base(pName)
        {
            Name = pName;
            string description = Description;
        }

        public Episode()
        {

        }

        public override string mediaType()
        {
            return "Episode";
        }

    }

}