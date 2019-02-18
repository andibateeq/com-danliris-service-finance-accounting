﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Danliris.Service.Finance.Accounting.Lib.ViewModels.CreditorAccount
{
    public class CreditorAccountUnitReceiptNotePostedViewModel : CreditorAccountPostedViewModel
    {
        public double DPP { get; set; }

        public double PPN { get; set; }

        public string Currency { get; set; }

        public string Products { get; set; }
    }
}
