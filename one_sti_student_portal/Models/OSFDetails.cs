﻿// Decompiled with JetBrains decompiler
// Type: one_sti_student_portal.Models.OSFDetails
// Assembly: one_sti_student_portal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 39E34984-485E-45CE-9895-F7524E3024D6
// Assembly location: \\wsl.localhost\kali-linux\root\One STI Student Portal_1.3.8_apkcombo.com (1)\unknown\assemblies\one_sti_student_portal.dll

using SQLite;

namespace one_sti_student_portal.Models
{
  public class OSFDetails
  {
    [PrimaryKey]
    [AutoIncrement]
    public int id { get; set; }

    public string pscs_id { get; set; }

    public string strm { get; set; }

    public string fee_code { get; set; }

    public string det_fee_code { get; set; }

    public string item_amount { get; set; }

    public string det_item_amount { get; set; }
  }
}
