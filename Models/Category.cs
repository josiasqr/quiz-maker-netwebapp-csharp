using System;
using System.Collections.Generic;

namespace quiz_maker_netwebapp_csharp.Models;

public partial class Category
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();
}
