﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace IpgaSystem.XPO.IpgaDB
{

    [Persistent(@"tb_eventos")]
    public partial class tb_eventosXPO : XPLiteObject
    {
        int feve_id;
        [Key(true)]
        public int eve_id
        {
            get { return feve_id; }
            set { SetPropertyValue<int>(nameof(eve_id), ref feve_id, value); }
        }
        string feve_nome;
        [Size(50)]
        public string eve_nome
        {
            get { return feve_nome; }
            set { SetPropertyValue<string>(nameof(eve_nome), ref feve_nome, value); }
        }
        DateTime feve_data_inicio;
        public DateTime eve_data_inicio
        {
            get { return feve_data_inicio; }
            set { SetPropertyValue<DateTime>(nameof(eve_data_inicio), ref feve_data_inicio, value); }
        }
        DateTime feve_data_termino;
        public DateTime eve_data_termino
        {
            get { return feve_data_termino; }
            set { SetPropertyValue<DateTime>(nameof(eve_data_termino), ref feve_data_termino, value); }
        }
        string feve_descricao;
        [Size(50)]
        public string eve_descricao
        {
            get { return feve_descricao; }
            set { SetPropertyValue<string>(nameof(eve_descricao), ref feve_descricao, value); }
        }
        decimal feve_valor_ingresso;
        public decimal eve_valor_ingresso
        {
            get { return feve_valor_ingresso; }
            set { SetPropertyValue<decimal>(nameof(eve_valor_ingresso), ref feve_valor_ingresso, value); }
        }
        string feve_local;
        [Size(50)]
        public string eve_local
        {
            get { return feve_local; }
            set { SetPropertyValue<string>(nameof(eve_local), ref feve_local, value); }
        }
    }

}