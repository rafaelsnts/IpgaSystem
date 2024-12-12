using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace IpgaSystem.XPO.IpgaDB
{

    public partial class tb_dizimosXPO
    {
        public tb_dizimosXPO(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
