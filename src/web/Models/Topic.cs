using System;
using System.Collections.Generic;
namespace Cosmos.Samples.NoSQL.Quickstart.Web.Models;

public class Topic
{
    public string id { get; private set; }
    public string Name{ get; set;}
    public double AggregateScore { get; set; }
    public int Score1Count { get; set; }
    public int Score2Count { get; set; }
    public int Score3Count { get; set; }
    public int Score4Count { get; set; }
    public int Score5Count { get; set; }
    public int Count {get; set;}
    public List<CommentInfo> Comments { get; set; }
    public List<float> Embeddings { get; set; }

    public Topic()
    {
        id = Guid.NewGuid().ToString(); // Generates a unique identifier
        Comments = new List<CommentInfo>();
    }
     public void AddComment(string commentId, List<string> relatedSentences)
    {
        Comments.Add(new CommentInfo { CommentId = commentId, RelatedSentences = relatedSentences });
    }

    public class CommentInfo
    {
        public string CommentId { get; set; }
        public List<string> RelatedSentences { get; set; }
    }

    public void IncrementScoreCount(int score)
    {
        switch (score)
        {
            case 1:
                Score1Count++;
                break;
            case 2:
                Score2Count++;
                break;
            case 3:
                Score3Count++;
                break;
            case 4:
                Score4Count++;
                break;
            case 5:
                Score5Count++;
                break;
        }
    }
}