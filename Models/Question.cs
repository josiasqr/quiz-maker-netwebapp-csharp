using System;
using System.Collections.Generic;

namespace quiz_maker_netwebapp_csharp.Models;

public partial class Question
{
    public long Id { get; set; }

    public string Question1 { get; set; } = null!;

    public long? CategoryId { get; set; }

    public long? QuizId { get; set; }

    public virtual ICollection<Answer> Answers { get; set; } = new List<Answer>();

    public virtual Category? Category { get; set; }

    public virtual Quiz? Quiz { get; set; }
}
