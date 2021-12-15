using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class SprSetting
    {
        public short Id { get; set; }
        public string ParamName { get; set; }
        public string ParamValue { get; set; }
        public string Commentt { get; set; }
    }
}
