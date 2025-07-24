namespace Dynamic_Form_Builder_Johan.ViewModel
{
    public class FormFieldVM
    {
        public int FormFieldId { get; set; }

        public int FormId { get; set; }

        public string? Label { get; set; }

        public bool IsRequired { get; set; }

        public string? Option { get; set; }
    }
}
