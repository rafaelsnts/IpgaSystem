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

    [Persistent(@"tb_dizimos")]
    public partial class tb_dizimosXPO : XPLiteObject
    {
        int fdiz_id;
        [Key(true)]
        public int diz_id
        {
            get { return fdiz_id; }
            set { SetPropertyValue<int>(nameof(diz_id), ref fdiz_id, value); }
        }
        DateTime fdiz_data;
        public DateTime diz_data
        {
            get { return fdiz_data; }
            set { SetPropertyValue<DateTime>(nameof(diz_data), ref fdiz_data, value); }
        }
        decimal fdiz_valor;
        public decimal diz_valor
        {
            get { return fdiz_valor; }
            set { SetPropertyValue<decimal>(nameof(diz_valor), ref fdiz_valor, value); }
        }
        tb_membrosXPO fdiz_fk_mem_id;
        [Association(@"tb_dizimosXPOReferencestb_membrosXPO")]
        public tb_membrosXPO diz_fk_mem_id
        {
            get { return fdiz_fk_mem_id; }
            set { SetPropertyValue<tb_membrosXPO>(nameof(diz_fk_mem_id), ref fdiz_fk_mem_id, value); }
        }
    }

}