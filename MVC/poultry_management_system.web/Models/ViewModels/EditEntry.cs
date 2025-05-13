namespace poultry_management_system.web.Models.ViewModels
{
    public class EditEntry
    {
        public Guid Id { get; set; }
        public int Age { get; set; }
        public int Opening_Birds { get; set; }
        public int Mortallity { get; set; }
        public int Closing_Birds { get; set; }
        public int Feed_Consume { get; set; }
        public int Avg_Weight { get; set; }
        public int Daily_Eggs_Production { get; set; }
        public string Health_Status { get; set; }
        public string Instruction { get; set; }
    }
}
