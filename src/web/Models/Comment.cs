using System;
using System.Collections.Generic;

public class Comment
{
    public string id { get; private set; } // Unique identifier for the topic
    public DateTime Startdate { get; set; }
    public DateTime LastModified { get; set; }
    public string KDPSurveyID {get; set;}
    public string activityId {get; set;}
    public string TopicName { get; set; }
    public int Score { get; set; }
    public List<RelatedSentence> RelatedSentences { get; set; }
    public List<float> Embeddings { get; set; }
    // Add any other properties that are relevant

    public Comment()
    {
        id = Guid.NewGuid().ToString(); // Auto-generate a unique ID upon creation
        LastModified = DateTime.Now;
    }

    public class RelatedSentence
    {
        public string FieldName { get; set; } // Name of the field in the data
        public string Content { get; set; } // Contents of the sentence related to that field
    }
}

