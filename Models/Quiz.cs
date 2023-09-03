using System;
using System.Collections.Generic;

namespace quiz_maker_netwebapp_csharp.Models;

public partial class Quiz
{
    public long Id { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
}
