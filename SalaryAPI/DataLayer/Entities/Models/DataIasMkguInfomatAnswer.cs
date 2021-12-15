using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataIasMkguInfomatAnswer
    {
        public Guid Id { get; set; }
        public string DataServicesInfoId { get; set; }
        public int SprIasMkguQuestionId { get; set; }
        public short SprIasMkguQuestionAnswerId { get; set; }
        public DateTime DateAnswer { get; set; }

        public virtual SprIasMkguQuestion SprIasMkguQuestion { get; set; }
        public virtual SprIasMkguQuestionAnswer SprIasMkguQuestionAnswer { get; set; }
    }
}
