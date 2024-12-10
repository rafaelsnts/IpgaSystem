﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



public partial class tb_nivel_acesso
{
    [Key]
    public int niv_id { get; set; }

    [StringLength(50)]
    
    public string niv_descricao { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? niv_data { get; set; }

    public int niv_nivel_acesso { get; set; }

    [InverseProperty("uso_fk_niv")]
    public virtual ICollection<tb_usuarios> tb_usuarios { get; set; } = new List<tb_usuarios>();
}