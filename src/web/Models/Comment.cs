using System;
using System.Collections.Generic;

public class Comment
{
    public string id { get; private set; } // Unique identifier for the topic
    public string KDPSurveyID {get; set;}
    public string activityId {get; set;}
    public string TopicName { get; set; }
    public int Score { get; set; }
    public List<string> RelatedSentences { get; set; }
    public List<float> Embeddings { get; set; }
    // Add any other properties that are relevant

    public Comment()
    {
        id = Guid.NewGuid().ToString(); // Auto-generate a unique ID upon creation
    }
}

