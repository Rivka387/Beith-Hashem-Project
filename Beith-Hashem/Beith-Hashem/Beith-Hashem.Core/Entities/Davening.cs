namespace beith_hashem.Core.Entities
{
    public enum DaveningType { Shacharit, Mincha, Maariv, SpecialDaven}
    public enum Day { Sunday, Monday, Tuesday, Wendsday, Thursday, Friday, Saturday }
    public enum MinyanType { Slow, Fast, InRetrospect }
    public class Davening
    {
        public int Id { get; set; }
        public DaveningType Type { get; set; }
        public DateOnly Time { get; set; }
        public string Location { get; set; }
        public Day DayOfWeek { get; set; }
        public int MaxCapacity { get; set; }
        public MinyanType MinyanType { get; set; }
        public bool WomenSection { get; set; }

        public Davening(int id, DaveningType type, DateOnly time, string location, Day dayOfWeek, int maxCapacity, MinyanType minyanType, bool womenSection)
        {
            Id = id;
            Type = type;
            Time = time;
            Location = location;
            DayOfWeek = dayOfWeek;
            MaxCapacity = maxCapacity;
            MinyanType = minyanType;
            WomenSection = womenSection;
        }
        public Davening()
        {
        }

    }
}
