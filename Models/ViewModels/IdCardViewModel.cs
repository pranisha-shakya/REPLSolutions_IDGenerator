namespace REPLSolutions_IDGenerator.Models.ViewModels
{
    public class IdCardViewModel
    {
        public required Student Student { get; set; }
        public required string PdfBase64 { get; set; }
    }
}
