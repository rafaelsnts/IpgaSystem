﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



public partial class tb_eventos
{
    [Key]
    public int eve_id { get; set; }

    [Required]
    [StringLength(50)]
    
    public string eve_nome { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? eve_data_inicio { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? eve_data_termino { get; set; }

    [StringLength(50)]
    
    public string eve_descricao { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? eve_valor_ingresso { get; set; }

    [StringLength(50)]
    
    public string eve_local { get; set; }
}