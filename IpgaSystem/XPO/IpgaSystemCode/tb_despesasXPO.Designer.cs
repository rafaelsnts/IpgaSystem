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

    [Persistent(@"tb_despesas")]
    public partial class tb_despesasXPO : XPLiteObject
    {
        int fdes_id;
        [Key(true)]
        public int des_id
        {
            get { return fdes_id; }
            set { SetPropertyValue<int>(nameof(des_id), ref fdes_id, value); }
        }
        string fdes_descricao;
        [Size(50)]
        public string des_descricao
        {
            get { return fdes_descricao; }
            set { SetPropertyValue<string>(nameof(des_descricao), ref fdes_descricao, value); }
        }
        decimal fdes_valor;
        public decimal des_valor
        {
            get { return fdes_valor; }
            set { SetPropertyValue<decimal>(nameof(des_valor), ref fdes_valor, value); }
        }
        DateTime fdes_data;
        public DateTime des_data
        {
            get { return fdes_data; }
            set { SetPropertyValue<DateTime>(nameof(des_data), ref fdes_data, value); }
        }
        string fdes_observacao;
        public string des_observacao
        {
            get { return fdes_observacao; }
            set { SetPropertyValue<string>(nameof(des_observacao), ref fdes_observacao, value); }
        }
    }

}
