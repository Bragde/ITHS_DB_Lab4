namespace ITHS_DB_Lab4
{
    class Exercise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Repetitions { get; set; }
        public int? PainLevel { get; set; }

        public int SessionId { get; set; }
        public Session Session { get; set; }
    }
}