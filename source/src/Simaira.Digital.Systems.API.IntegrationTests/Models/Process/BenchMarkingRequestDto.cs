namespace Ecolab.Simaira.Digital.CustomerPortal.Model.Process
{
    using global::System.Collections.Generic;
    using global::System.ComponentModel.DataAnnotations;
    using static Ecolab.Simaira.Digital.CustomerPortal.Model.Constants;

    public class BenchMarkingRequestDto
    {
        public IEnumerable<ProgramCategory> Categories { get; set; }

        [Required]
        public IEnumerable<string> AccountNumbers { get; set; }

        [Required]
        public int CustomerKey { get; set; }

        public string UserEmail { get; set; }

        [Required]
        public int NumberofDays { get; set; }
    }
}