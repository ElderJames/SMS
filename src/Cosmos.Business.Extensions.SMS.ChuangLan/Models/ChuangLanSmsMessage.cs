﻿using System.Collections.Generic;
using Cosmos.Business.Extensions.SMS.ChuangLan.Exceptions;

namespace Cosmos.Business.Extensions.SMS.ChuangLan.Models
{
    public class ChuangLanSmsMessage: ChuangLanSmsBase
    {
        public List<string> PhoneNumbers { get; set; }=new List<string>();

        public string Content { get; set; }

        public string GetPhoneString() => string.Join(",", PhoneNumbers);

        public void CheckParameters()
        {
            var phoneCount = PhoneNumbers?.Count;
            if (phoneCount == 0)
            {
                throw new ChuangLanSmsException("收信人为空");
            }

            if (string.IsNullOrWhiteSpace(Content))
            {
                throw new ChuangLanSmsException("信息为空");
            }
        }
    }
}
