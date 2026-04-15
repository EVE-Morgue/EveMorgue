using System;
using System.Collections.Generic;
using System.Text;

namespace EVEMorgue.Infrastructure.DTO
{
    public class EsiTypeDto
    {
        public int TypeId { get; set; }
        public string Name { get; set; } = default!;
        public int GroupId { get; set; }
        public bool Published { get; set; }
    }

    public class EsiGroupDto
    {
        public int GroupId { get; set; }
        public int CategoryId { get; set; }
        public IReadOnlyList<int> TypeIds { get; set; } = new List<int>();
    }

    public class EsiCategoryDto
    {
        public int CategoryId { get; set; }
        public string Name { get; set; } = default!;
        public IReadOnlyList<int> GroupIds { get; set; } = new List<int>();
    }
}
