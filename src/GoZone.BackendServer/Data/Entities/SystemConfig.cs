﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoZone.BackendServer.Data.Entities
{
    [Table("SystemConfigs")]
    public class SystemConfig
    {
        #region Basic
        [Required, Key, MaxLength(50), Column(TypeName = "varchar(50)")]
        public string Name { get; set; }
        public string Value { get; set; }
        #endregion
    }
}
