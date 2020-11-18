﻿//-------------------------------------------------------------------------
// Copyright (c) The Zig Group Ltd.  All rights reserved.
//-------------------------------------------------------------------------
using Microsoft.Azure.Cosmos.Table;
using Newtonsoft.Json;
using System;
using ZigOps.PaymentProcessing.Data.Helpers;

namespace ZigOps.PaymentProcessing.Data.Models.TransferWise.Database
{
    public class Funded : TableEntity
    {
        public Funded()
        {
            PartitionKey = Constants.TableDBConstant.TRANSFERWISE_FUND_TRANSFERS_PARTITION;
            RowKey = Guid.NewGuid().ToString();
            CreatedAt = DateTime.UtcNow;
        }

        [JsonProperty("Request")]
        public string Request { get; set; }

        [JsonProperty("Response")]
        public string Response { get; set; }

        [JsonProperty("CreatedAt")]
        public DateTime CreatedAt { get; set; }
    }
}
