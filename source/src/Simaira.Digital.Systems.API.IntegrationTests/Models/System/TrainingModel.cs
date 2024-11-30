namespace Ecolab.Simaira.Digital.CustomerPortal.Model
{
    using Newtonsoft.Json;

    public class TrainingModel
    {
        [JsonProperty(PropertyName = "trainingURL")]
        public string TrainingURL { get; set; }
        [JsonProperty(PropertyName = "trainingTitle")]
        public string TrainingTitle { get; set; }
        [JsonProperty(PropertyName = "trainingText")]
        public string TrainingText { get; set; }
        [JsonProperty(PropertyName = "trainingPictureURL")]
        public string TrainingPictureURL { get; set; }
    }
}
