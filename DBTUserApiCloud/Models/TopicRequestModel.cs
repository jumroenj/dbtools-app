namespace DBTUserApiCloud.Models
{
    public class TopicRequestModel
    {
        public int TOPIC_ID { get; set; }
        public string TOPIC_CODE { get; set; }
        public string TARGET_URL { get; set; }


        public List<ParamRequestModel> PARAM_LIST { get; set; }

    }
}
