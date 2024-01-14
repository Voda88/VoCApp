using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Cosmos.Samples.NoSQL.Quickstart.Web.Models;

public class Topic
{
    [JsonProperty("id")]
    public string Name{ get; set;}
    public double AggregateScore { get; set; }
    public int Score1Count { get; set; }
    public int Score2Count { get; set; }
    public int Score3Count { get; set; }
    public int Score4Count { get; set; }
    public int Score5Count { get; set; }
    public int Score6Count { get; set; }
    public int Score7Count { get; set; }
    public int Score8Count { get; set; }
    public int Score9Count { get; set; }
    public int Score10Count { get; set; }
    public int Count {get; set;}
    public List<float> Embeddings { get; set; }

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
            case 6:
                Score6Count++;
                break;
            case 7:
                Score7Count++;
                break;
            case 8:
                Score8Count++;
                break;
            case 9:
                Score9Count++;
                break;
            case 10:
                Score10Count++;
                break;
        }
    }
}