namespace Models
{
    public abstract class Media
    {
        public string Name { get; set; }

        public Media(string pName)
        {
            Name = pName;
        }

        public Media()
        {
        }

        public virtual string mediaType()
        {
            return "Media";
        }
    }
}