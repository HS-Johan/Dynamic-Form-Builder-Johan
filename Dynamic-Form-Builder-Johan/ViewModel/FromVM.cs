namespace Dynamic_Form_Builder_Johan.ViewModel
{
    public class FromVM
    {
        public int FormId { get; set; }

        public string? Title { get; set; }

        public List<FormFieldVM> Fields { get; set; } = new();
    }
}
