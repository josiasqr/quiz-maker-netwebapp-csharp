using System;
using System.Collections.Generic;

namespace quiz_maker_netwebapp_csharp.Models;

public partial class Answer
{
    public long Id { get; set; }

    public string Answer1 { get; set; } = null!;

    public ulong Correct { get; set; }

    public long? QuestionsId { get; set; }

    public virtual Question? Questions { get; set; }
}
